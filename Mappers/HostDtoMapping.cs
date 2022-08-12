using System;

using AutoMapper;

using JsonMessageApi.Models;
using JsonMessageApi.Models.Constants;

namespace JsonMessageApi.Mappers
{

    // Map object attributes automatically - uses the AutoMapper package
    public class HostDtoMapping : Profile
    {
        public HostDtoMapping()
        {
            // Map source to destination...

            //--------------------------------------------------------------------------------------------
            // Hdr = Bi-directional to & from ERP
            //--------------------------------------------------------------------------------------------

            //// Hdr => HostMessage
            //CreateMap<HdrDto, HostMessage>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.Hdr))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.MessageType))
            //    .ForMember(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.MessageVersion))
            //    .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
            //    .ForMember(dest => dest.RefId, opt => opt.MapFrom(src => src.UniqueKey))
            //    .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Timestamp, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<HostMessage, HdrDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Hdr => Hdr.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    .ForMember(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
            //    .ForMember(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForMember(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.DestinationId, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ResendCounter, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Timestamp))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<HdrDto, HostMessage>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.Hdr))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(Constant.Undefined))
            //    .ForMember(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.MessageVersion))
            //    .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
            //    .ForMember(dest => dest.RefId, opt => opt.MapFrom(src => src.UniqueKey))
            //    .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Timestamp, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<HostMessage, HdrDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Hdr => Hdr.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    .ForMember(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
            //    .ForMember(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForMember(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.DestinationId, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ResendCounter, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Timestamp))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //--------------------------------------------------------------------------------------------
            // NS = From ERP
            //--------------------------------------------------------------------------------------------

            // NS_ArticleCreate => CreateMaterialMaster
            CreateMap<MessageDto, CreateMaterialMaster>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(dest => dest.recordType, opt => opt.UseValue<RecordType>(RecordType.CreateMaterialMaster))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Timestamp, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Sku))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.WarehouseCode))
                .ForPath(dest => dest.Description, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Description))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusActivity))
                //.ForMember(dest => dest.AbcArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.PackagingUnit, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.IsLotNoRequired, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription1, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription2, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription3, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription4, opt => opt.MapFrom(src => src.????))
                .ForAllMembers(x => x.Condition((source, destination, property) =>
                {
                    // Ignore null objects & empty string properties
                    if (property == null)
                        return false;
                    if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
                        return false;
                    if (property.GetType() == typeof(int) && int.Equals(property, 0))
                        return false;
                    if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
                        return false;

                    return true;
                }));
            CreateMap<CreateMaterialMaster, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(NS_ArticleCreate => NS_ArticleCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                // Header
                //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
                .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
                .ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
                .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
                //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
                //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Timestamp))
                // Request
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src.))
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Description, opt => opt.MapFrom(src => src.Description))
                //.ForMember(dest => dest.BonusActivity, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.AbcArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PackagingUnit))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.IsLotNoRequired))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Client))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription1))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription2))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription3))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription4))
                .ForAllMembers(x => x.Condition((source, destination, property) =>
                {
                    // Ignore null objects & empty string properties
                    if (property == null)
                        return false;
                    if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
                        return false;
                    if (property.GetType() == typeof(int) && int.Equals(property, 0))
                        return false;
                    if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
                        return false;

                    return true;
                }));
            CreateMap<MessageDto, CreateMaterialMaster>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(dest => dest.recordType, opt => opt.UseValue<RecordType>(RecordType.CreateMaterialMaster))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Timestamp, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Sku))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.WarehouseCode))
                .ForPath(dest => dest.Description, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Description))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusActivity))
                //.ForMember(dest => dest.AbcArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.PackagingUnit, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.IsLotNoRequired, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription1, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription2, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription3, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Subdescription4, opt => opt.MapFrom(src => src.????))
                .ForAllMembers(x => x.Condition((source, destination, property) =>
                {
                    // Ignore null objects & empty string properties
                    if (property == null)
                        return false;
                    if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
                        return false;
                    if (property.GetType() == typeof(int) && int.Equals(property, 0))
                        return false;
                    if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
                        return false;

                    return true;
                }));
            CreateMap<CreateMaterialMaster, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(NS_ArticleCreate => NS_ArticleCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                // Header
                //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
                .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
                //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
                .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
                //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
                //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Timestamp))
                // Request
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src.))
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Description, opt => opt.MapFrom(src => src.Description))
                //.ForMember(dest => dest.BonusActivity, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.AbcArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PackagingUnit))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.IsLotNoRequired))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Client))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription1))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription2))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription3))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription4))
                .ForAllMembers(x => x.Condition((source, destination, property) =>
                {
                    // Ignore null objects & empty string properties
                    if (property == null)
                        return false;
                    if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
                        return false;
                    if (property.GetType() == typeof(int) && int.Equals(property, 0))
                        return false;
                    if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
                        return false;

                    return true;
                }));

            //// NS_OrderCreate => IncomingGoods
            //CreateMap<NS_OrderCreateDto, IncomingGoods>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCreate))
            //    .ForMember(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchReference))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Destination))
            //    .ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.WarehouseCode))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickByTime))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchDescription))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchEndAllowed))
            //    //.ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Positions, opt => opt.MapFrom(src => src.OrderLines))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<IncomingGoods, NS_OrderCreateDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForMember(dest => dest.OrderReference, opt => opt.MapFrom(src => src.IncomingGoodsNo))
            //    //.ForMember(dest => dest.BatchReference, opt => opt.MapFrom(src => src.BatchReference))
            //    //.ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Destination))
            //    .ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
            //    //.ForMember(dest => dest.PickByTime, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.BatchDescription, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.BatchEndAllowed, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Client))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
            //    .ForMember(dest => dest.OrderLines, opt => opt.MapFrom(src => src.OrderLines))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<NS_OrderCreateDto, IncomingGoods>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCreate))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<IncomingGoods, NS_OrderCreateDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// NS_OrderUpdate => 
            //CreateMap<NS_OrderUpdateDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderUpdate))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickByTime))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, NS_OrderUpdateDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderUpdate => NS_OrderUpdate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<NS_OrderUpdateDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderUpdate))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, NS_OrderUpdateDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderUpdate => NS_OrderUpdate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// NS_OrderCancel => 
            //CreateMap<NS_OrderCancelDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.????, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCancel))
            ///*.F*/
            //          orMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, NS_OrderCancelDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderCancel => NS_OrderCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<NS_OrderCancelDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, NS_OrderCancelDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderCancel => NS_OrderCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// NS_OrderLineCancel => 
            //CreateMap<NS_OrderLineCancelDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderLineCancel))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, NS_OrderLineCancelDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderLineCancel => NS_OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<NS_OrderLineCancelDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, NS_OrderLineCancelDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_OrderLineCancel => NS_OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// NS_ValidationError => 
            //CreateMap<NS_ValidationErrorDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_ValidationError))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MessageType))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MessageVersion))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Created))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.UniqueKey))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SenderId))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationId))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, NS_ValidationErrorDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_ValidationError => NS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<NS_ValidationErrorDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_ValidationError))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, NS_ValidationErrorDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(NS_ValidationError => NS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            ////--------------------------------------------------------------------------------------------
            //// GS = To ERP
            ////--------------------------------------------------------------------------------------------

            //// GS_StockAdjustment => QuantityCorrection
            //CreateMap<GS_StockAdjustmentDto, QuantityCorrection>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_StockAdjustment))
            //    .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
            //    .ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.WarehouseCode))
            //    .ForMember(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Quantity))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.AdjustmentDate))
            //    .ForMember(dest => dest.Barcode, opt => opt.MapFrom(src => src.Bdcid))
            //    .ForMember(dest => dest.Barcode, opt => opt.MapFrom(src => src.Upos))
            //    .ForMember(dest => dest.ReasonCode, opt => opt.MapFrom(src => src.AdjustmentReason))
            //    .ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.BonusNo))
            //    //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_StockAdjustmentDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_StockAdjustmentDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_StockAdjustment))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_StockAdjustmentDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_StockAdjustment => GS_StockAdjustment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_InventorySnapshot => StockReport
            //CreateMap<GS_InventorySnapshotDto, StockReport>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_InventorySnapshot))
            //    .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
            //    .ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.WarehouseCode))
            //    .ForMember(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Quantity))
            //    .ForMember(dest => dest.LastIncoming, opt => opt.MapFrom(src => src.LastInductDate))
            //    .ForMember(dest => dest.LastOutgoing, opt => opt.MapFrom(src => src.LastRetrievedDate))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_InventorySnapshotDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_InventorySnapshot => GS_InventorySnapshot.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_InventorySnapshotDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_InventorySnapshot))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_InventorySnapshotDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_InventorySnapshot => GS_InventorySnapshot.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_PickConfirmation => OutgoingGoodsPositionConfirmation
            //CreateMap<GS_PickConfirmationDto, OutgoingGoodsPositionConfirmation>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickConfirmation))
            //    .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderReference))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.TubNo, opt => opt.MapFrom(src => src.ToteId))
            //    .ForMember(dest => dest.Barcode, opt => opt.MapFrom(src => src.PickedUpos))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickTime))
            //    //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.ActualQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.DestinationRackNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.DestinationRackPosition, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_PickConfirmationDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_PickConfirmation => GS_PickConfirmation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_PickConfirmationDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickConfirmation))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_PickConfirmationDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_PickConfirmation => GS_PickConfirmation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_ToteAssignment => TubAssignment
            //CreateMap<GS_ToteAssignmentDto, TubAssignment>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ToteAssignment))
            //    .ForMember(dest => dest.TubNo, opt => opt.MapFrom(src => src.ToteId))
            //    .ForMember(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.TrolleyId))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderLineNo))
            //    .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Destination))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationId))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationPure))
            //    //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_ToteAssignmentDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_ToteAssignment => GS_ToteAssignment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_ToteAssignmentDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ToteAssignment))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_ToteAssignmentDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_ToteAssignment => GS_ToteAssignment.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_TrolleyComplete => 
            //CreateMap<GS_TrolleyCompleteDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_TrolleyComplete))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.TrolleyId))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.Totes))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_TrolleyCompleteDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_TrolleyComplete => GS_TrolleyComplete.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_TrolleyCompleteDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_TrolleyComplete))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_TrolleyCompleteDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_TrolleyComplete => GS_TrolleyComplete.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_PickCancellation => 
            //CreateMap<GS_PickCancellationDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellation))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.BonusNo))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.ReasonCode))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.CancellationsDto))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_PickCancellationDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_PickCancellation => GS_PickCancellation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_PickCancellationDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellation))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_PickCancellationDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_PickCancellation => GS_PickCancellation.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_PickCancellationRequest => 
            //CreateMap<GS_PickCancellationRequestDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellationRequest))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.BonusNo))
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.CancellationRequestsDto))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_PickCancellationRequestDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_PickCancellationRequest => GS_PickCancellationRequest.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_PickCancellationRequestDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellationRequest))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_PickCancellationRequestDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_PickCancellationRequest => GS_PickCancellationRequest.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_Event => 
            //CreateMap<GS_EventDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_Event))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.EventTime))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusActivity))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.WarehouseCode))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_EventDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_Event => GS_Event.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_EventDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_Event))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_EventDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_Event => GS_Event.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// GS_ValidationError => 
            //CreateMap<GS_ValidationErrorDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ValidationError))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, GS_ValidationErrorDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_ValidationError => GS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<GS_ValidationErrorDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ValidationError))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, GS_ValidationErrorDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(GS_ValidationError => GS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            ////--------------------------------------------------------------------------------------------
            //// List entities
            ////--------------------------------------------------------------------------------------------

            //// Tote => 
            //CreateMap<ToteDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.Tote))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.ToteId))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, ToteDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Tote => Tote.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToteDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.Tote))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, ToteDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Tote => Tote.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// OrderLine => IncomingGoodsPosition
            //CreateMap<OrderLineDto, IncomingGoodsPosition>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLine))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    .ForMember(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PriorityWithinBatch))
            //    //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.SpecialStockNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.SpecialStockIndicator, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.FiFo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<IncomingGoodsPosition, OrderLineDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(dest => dest.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
            //    .ForMember(dest => dest.OrderLineReference, opt => opt.MapFrom(src => src.IncomingGoodsNo))
            //    .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
            //    //.ForMember(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ExpirationDate))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockIndicator))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.FiFo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
            //    //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<OrderLineDto, IncomingGoodsPosition>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLine))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    .ForMember(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PriorityWithinBatch))
            //    //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.SpecialStockNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.SpecialStockIndicator, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.FiFo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<IncomingGoodsPosition, OrderLineDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(dest => dest.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
            //    .ForMember(dest => dest.OrderLineReference, opt => opt.MapFrom(src => src.IncomingGoodsNo))
            //    .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
            //    //.ForMember(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ExpirationDate))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockIndicator))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.FiFo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
            //    //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// OrderLine => OutgoingGoodsPosition
            //CreateMap<OrderLineDto, OutgoingGoodsPosition>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLine))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PriorityWithinBatch))
            //    //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<OutgoingGoodsPosition, OrderLineDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(dest => dest.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
            //    .ForMember(dest => dest.OrderLineReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
            //    .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
            //    //.ForMember(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Client))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
            //    //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<OrderLineDto, OutgoingGoodsPosition>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLine))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PriorityWithinBatch))
            //    //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<OutgoingGoodsPosition, OrderLineDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(dest => dest.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
            //    .ForMember(dest => dest.OrderLineReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
            //    .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
            //    //.ForMember(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Client))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
            //    //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// OrderLineCancel => 
            //CreateMap<OrderLineCancelDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLineCancel))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, OrderLineCancelDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(OrderLineCancel => OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<OrderLineCancelDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, OrderLineCancelDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(OrderLineCancel => OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// CancellationDto => PickCancelation
            //CreateMap<CancellationDto, PickCancelation>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.Cancellation))
            //    .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.CancelQty, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.ReasonCode, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, CancellationDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Cancellations => Cancellations.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<CancellationDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.Cancellation))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, CancellationDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Cancellations => Cancellations.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// CancellationRequests => CancelRequest
            //CreateMap<CancellationRequestsDto, RequestCancelation>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancellationRequests))
            //    .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, CancellationRequestsDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(CancellationRequests => CancellationRequests.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<CancellationRequestsDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancellationRequests))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, CancellationRequestsDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(CancellationRequests => CancellationRequests.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        }
    }
}