using System;
using System.ComponentModel;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using AutoMapper.Configuration;
//Add Package : AutoMapper.Extensions.ExpressionMapping Version 4.1.0
using AutoMapper.Extensions.ExpressionMapping;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using Gebhardt.StoreWare.WcsWms.InterfaceWcsWms.Interfaces;
using Gebhardt.StoreWare.WcsWms.InterfaceWcsWms.Models;
using Gebhardt.StoreWare.WcsWms.InterfaceWcsWms.EntityFramework;
using Gebhardt.StoreWare.WcsWms.InterfaceWcsWms.EntityFramework.Models;

using Gebhardt.Shared;
using Gebhardt.StoreWare.WcsWms.InterfaceWcsWms.Mapping;
using Gebhardt.StoreWare.Wcs.HostComWebService.Model;
using Gebhardt.StoreWare.Infrastructure;
using JsonMessageApi.Models;

namespace Gebhardt.StoreWare.Wcs.HostComWebService.Mapping
{

	public static partial class HostDtoMapping
	{
		public static class RecordType
		{
			// Header
			public const string Hdr = "Hdr";

			public const string HostMessage = "HostMessage";

			// From ERP table
			public const string CreateMaterialMaster = "CreateMaterialMaster";
			public const string DeleteMaterialMaster = "DeleteMaterialMaster";
			public const string IncomingGoods = "IncomingGoods";
			public const string IncomingGoodsConfirmation = "IncomingGoodsConfirmation";
			public const string IncomingGoodsPosition = "IncomingGoodsPosition";
			public const string OrderStart = "OrderStart";
			public const string CancelRequestReply = "CancelRequestReply";

            public const string OrderUpdate = "OrderUpdate";
            public const string OrderCancel = "OrderCancel";
            public const string OrderLineCancel = "OrderLineCancel";
            public const string ValidationErrorFromErp = "ValidationErrorFromErp";

            // To ERP table
            public const string QuantityCorrection = "QuantityCorrection";
			public const string StockReport = "StockReport";
			public const string OutgoingGoodsConfirmation = "OutgoingGoodsConfirmation";
			public const string OutgoingGoodsConfirmationPosition = "OutgoingGoodsConfirmationPosition";
			public const string OutgoingGoodsPosition = "OutgoingGoodsPosition";
			public const string OutgoingGoodsPositionConfirmation = "OutgoingGoodsPositionConfirmation";
			public const string TubAssignment = "TubAssignment";
			public const string PickCancelation = "PickCancelation";
			public const string CancelRequest = "CancelRequest";

            public const string TrolleyComplete = "TrolleyComplete";
            public const string SystemActivity = "SystemActivity";
            public const string ValidationErrorToErp = "ValidationErrorToErp";
        }

		/// <summary>
		/// Mapping between FromErp/ToErp and the json Telegrams
		/// For Testing purpouses: All Telegrams can be mapped to either From/ToErp
		/// </summary>
		/// <returns></returns>
		public static IMapper HostDtoMapper()
		{
			//Get global Mapping-Configurations from StoreWareBase
			MapperConfigurationExpression cfg = AutoMapperConfig.GetConfiguration();

			//cfg.SourceMemberNamingConvention = new WcsWms.InterfaceWcsWms.Mapping.DatabaseNamingConvention();
			////cfg.DestinationMemberNamingConvention = new PascalCaseNamingConvention();
			//cfg.AddExpressionMapping();



			// UnsupportedHostMessage
			cfg.CreateMap<UnsupportedHostMessage, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(a => a.ErrorInterface, opts => opts.MapFrom(a => "incorrect RecordType"))
				//.ForMember(a => a.Status, opts => opts.MapFrom(a => "Failed"))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, UnsupportedHostMessage>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(a => a.ErrorInterface, opts => opts.MapFrom(a => "incorrect RecordType"))
				//.ForMember(a => a.Status, opts => opts.MapFrom(a => "Failed"))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<UnsupportedHostMessage, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(a => a.ErrorInterface, opts => opts.MapFrom(a => "incorrect RecordType"))
				//.ForMember(a => a.Status, opts => opts.MapFrom(a => "Failed"))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, UnsupportedHostMessage>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(a => a.ErrorInterface, opts => opts.MapFrom(a => "incorrect RecordType"))
				//.ForMember(a => a.Status, opts => opts.MapFrom(a => "Failed"))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// HostMessage
			cfg.CreateMap<HostMessage, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.HostMessage))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, HostMessage>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(Hdr => Hdr.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<HostMessage, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.HostMessage))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, HostMessage>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(Hdr => Hdr.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// CreateMaterialMaster
			cfg.CreateMap<CreateMaterialMaster, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CreateMaterialMaster))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, CreateMaterialMaster>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_ArticleCreate => NS_ArticleCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<CreateMaterialMaster, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CreateMaterialMaster))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, CreateMaterialMaster>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_ArticleCreate => NS_ArticleCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// DeleteMaterialMaster
			cfg.CreateMap<DeleteMaterialMaster, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.DeleteMaterialMaster))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, DeleteMaterialMaster>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<DeleteMaterialMaster, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.DeleteMaterialMaster))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, DeleteMaterialMaster>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// IncomingGoods
			cfg.CreateMap<IncomingGoods, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.IncomingGoods))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, IncomingGoods>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderUpdate => NS_OrderUpdate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<IncomingGoods, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.IncomingGoods))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, IncomingGoods>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderUpdate => NS_OrderUpdate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// IncomingGoodsConfirmation
			cfg.CreateMap<IncomingGoodsConfirmation, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.IncomingGoodsConfirmation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, IncomingGoodsConfirmation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderCancel => NS_OrderCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<IncomingGoodsConfirmation, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.IncomingGoodsConfirmation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, IncomingGoodsConfirmation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderCancel => NS_OrderCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// IncomingGoodsPosition
			cfg.CreateMap<IncomingGoodsPosition, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.IncomingGoodsPosition))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, IncomingGoodsPosition>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderLineCancel => NS_OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<IncomingGoodsPosition, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.IncomingGoodsPosition))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, IncomingGoodsPosition>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_OrderLineCancel => NS_OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// OrderStart
			cfg.CreateMap<OrderStart, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderStart))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, OrderStart>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_ValidationError => NS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<OrderStart, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderStart))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, OrderStart>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(NS_ValidationError => NS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// CancelRequestReply
			cfg.CreateMap<CancelRequestReply, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancelRequestReply))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, CancelRequestReply>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<CancelRequestReply, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancelRequestReply))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, CancelRequestReply>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // OrderUpdate
            cfg.CreateMap<OrderUpdate, FromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderUpdate))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<FromErp, OrderUpdate>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<OrderUpdate, ToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderUpdate))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ToErp, OrderUpdate>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // OrderCancel
            cfg.CreateMap<OrderCancel, FromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderCancel))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<FromErp, OrderCancel>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<OrderCancel, ToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderCancel))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ToErp, OrderCancel>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // OrderLineCancel
            cfg.CreateMap<OrderLineCancel, FromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLineCancel))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<FromErp, OrderLineCancel>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<OrderLineCancel, ToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLineCancel))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ToErp, OrderLineCancel>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // ValidationErrorFromErp
            cfg.CreateMap<ValidationErrorFromErp, FromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.ValidationErrorFromErp))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<FromErp, ValidationErrorFromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ValidationErrorFromErp, ToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.ValidationErrorFromErp))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ToErp, ValidationErrorFromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //--------------------------------------------------------------------------------------------
            // GS = To ERP
            //--------------------------------------------------------------------------------------------

            // QuantityCorrection
            cfg.CreateMap<QuantityCorrection, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.QuantityCorrection))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, QuantityCorrection>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_InventorySnapshot => GS_InventorySnapshot.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<QuantityCorrection, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.QuantityCorrection))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, QuantityCorrection>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_InventorySnapshot => GS_InventorySnapshot.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// StockReport
			cfg.CreateMap<StockReport, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.StockReport))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, StockReport>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_PickConfirmation => GS_PickConfirmation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<StockReport, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.StockReport))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, StockReport>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_PickConfirmation => GS_PickConfirmation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// OutgoingGoodsConfirmation
			cfg.CreateMap<OutgoingGoodsConfirmation, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsConfirmation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, OutgoingGoodsConfirmation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_ToteAssignment => GS_ToteAssignment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<OutgoingGoodsConfirmation, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsConfirmation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, OutgoingGoodsConfirmation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_ToteAssignment => GS_ToteAssignment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// OutgoingGoodsConfirmationPosition
			cfg.CreateMap<OutgoingGoodsConfirmationPosition, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsConfirmationPosition))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, OutgoingGoodsConfirmationPosition>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_TrolleyComplete => GS_TrolleyComplete.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<OutgoingGoodsConfirmationPosition, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsConfirmationPosition))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, OutgoingGoodsConfirmationPosition>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_TrolleyComplete => GS_TrolleyComplete.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// OutgoingGoodsPosition
			cfg.CreateMap<OutgoingGoodsPosition, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsPosition))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, OutgoingGoodsPosition>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_PickCancellation => GS_PickCancellation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<OutgoingGoodsPosition, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsPosition))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, OutgoingGoodsPosition>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_PickCancellation => GS_PickCancellation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// OutgoingGoodsPositionConfirmation
			cfg.CreateMap<OutgoingGoodsPositionConfirmation, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsPositionConfirmation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, OutgoingGoodsPositionConfirmation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_PickCancellationRequest => GS_PickCancellationRequest.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<OutgoingGoodsPositionConfirmation, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OutgoingGoodsPositionConfirmation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, OutgoingGoodsPositionConfirmation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_PickCancellationRequest => GS_PickCancellationRequest.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// TubAssignment
			cfg.CreateMap<TubAssignment, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.TubAssignment))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, TubAssignment>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_Event => GS_Event.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<TubAssignment, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.TubAssignment))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, TubAssignment>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_Event => GS_Event.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// PickCancelation
			cfg.CreateMap<PickCancelation, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.PickCancelation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, PickCancelation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_ValidationError => GS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<PickCancelation, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.PickCancelation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, PickCancelation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(GS_ValidationError => GS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// RequestCancelation
			cfg.CreateMap<RequestCancelation, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.RequestCancelation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, RequestCancelation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(Tote => Tote.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<RequestCancelation, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.RequestCancelation))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, RequestCancelation>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(Tote => Tote.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

			// CancelRequest
			cfg.CreateMap<CancelRequest, FromErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancelRequest))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<FromErp, CancelRequest>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<CancelRequest, ToErp>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancelRequest))
				//.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
			cfg.CreateMap<ToErp, CancelRequest>()
				.IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
				//.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
				.ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // TrolleyComplete
            cfg.CreateMap<TrolleyComplete, FromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.TrolleyComplete))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<FromErp, TrolleyComplete>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<TrolleyComplete, ToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.TrolleyComplete))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ToErp, TrolleyComplete>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // SystemActivity
            cfg.CreateMap<SystemActivity, FromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.SystemActivity))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<FromErp, SystemActivity>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<SystemActivity, ToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.SystemActivity))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ToErp, SystemActivity>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            // ValidationErrorToErp
            cfg.CreateMap<ValidationErrorToErp, FromErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.ValidationErrorToErp))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<FromErp, ValidationErrorToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ValidationErrorToErp, ToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.ValidationErrorToErp))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            cfg.CreateMap<ToErp, ValidationErrorToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            MapperConfiguration mapperConfig = new MapperConfiguration(cfg);

			return mapperConfig.CreateMapper();
		}
	}

}