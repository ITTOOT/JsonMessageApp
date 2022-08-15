using System;
using System.Globalization;
using System.Text.RegularExpressions;

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
            // Get current time
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            var region = new CultureInfo("en-GB");
            

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
                // Header
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
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Sku))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.WarehouseCode))
                .ForPath(dest => dest.Description, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Description))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusActivity))
                //.ForMember(dest => dest.AbcArea, opt => opt.MapFrom(src => src.HotZoneClassification))
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
                // Header
                //.ForMember(NS_ArticleCreate => NS_ArticleCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src.))
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Description, opt => opt.MapFrom(src => src.Description))
                //.ForMember(dest => dest.BonusActivity, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.HotZoneClassification, opt => opt.MapFrom(src => src.AbcArea))
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
                // Header
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
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Sku))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.WarehouseCode))
                .ForPath(dest => dest.Description, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Description))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusActivity))
                //.ForMember(dest => dest.AbcArea, opt => opt.MapFrom(src => src.HotZoneClassification))
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
                // Header
                //.ForMember(NS_ArticleCreate => NS_ArticleCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src.))
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Description, opt => opt.MapFrom(src => src.Description))
                //.ForMember(dest => dest.BonusActivity, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.HotZoneClassification, opt => opt.MapFrom(src => src.AbcArea))
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

            // NS_OrderCreate => IncomingGoods
            CreateMap<MessageDto, IncomingGoods>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCreate))
                .ForMember(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Destination))
                .ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.WarehouseCode))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickByTime))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchDescription))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchEndAllowed))
                .ForMember(dest => dest.Positions, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.OrderLines))
                //.ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<IncomingGoods, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCreate))
                .ForMember(dest => dest.Request.NS_OrderCreate.OrderReference, opt => opt.MapFrom(src => src.IncomingGoodsNo))
                //.ForMember(dest => dest.BatchReference, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Request.NS_OrderCreate.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.PickByTime), opt => opt.MapFrom(src => src.????)
                //.ForMember(dest => dest.BatchDescription, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.BatchEndAllowed, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Request.NS_OrderCreate.OrderLines, opt => opt.MapFrom(src => src.Positions))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Client))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<MessageDto, IncomingGoods>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCreate))
                .ForMember(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Destination))
                .ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.WarehouseCode))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickByTime))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchDescription))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchEndAllowed))
                .ForMember(dest => dest.Positions, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.OrderLines))
                //.ForMember(dest => dest.Client, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<IncomingGoods, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCreate))
                .ForMember(dest => dest.Request.NS_OrderCreate.OrderReference, opt => opt.MapFrom(src => src.IncomingGoodsNo))
                //.ForMember(dest => dest.BatchReference, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Request.NS_OrderCreate.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.PickByTime), opt => opt.MapFrom(src => src.????)
                //.ForMember(dest => dest.BatchDescription, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.BatchEndAllowed, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Request.NS_OrderCreate.OrderLines, opt => opt.MapFrom(src => src.Positions))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Client))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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

            //// NS_OrderUpdate => 
            //CreateMap<MessageDto, ????>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickByTime))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))

            //CreateMap<????, MessageDto >()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_OrderUpdate => NS_OrderUpdate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))

            //CreateMap<MessageDto, ????> ()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request

            //CreateMap<????, MessageDto >()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_OrderUpdate => NS_OrderUpdate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))


            //// NS_OrderCancel => 
            //CreateMap < MessageDto, ????> ()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.????, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderCancel))
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    .ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap <????, MessageDto > ()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_OrderCancel => NS_OrderCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap < MessageDto, ????> ()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap <????, MessageDto > ()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_OrderCancel => NS_OrderCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// NS_OrderLineCancel => 
            //CreateMap<MessageDto, ????>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderLineCancel))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<????, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_OrderLineCancel => NS_OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<MessageDto, ????>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<????, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_OrderLineCancel => NS_OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// NS_ValidationError => 
            //CreateMap<MessageDto, ????>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
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
            //CreateMap<????, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_ValidationError => NS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<MessageDto, ????>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.NS_ValidationError))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<????, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(NS_ValidationError => NS_ValidationError.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //--------------------------------------------------------------------------------------------
            // GS = To ERP
            //--------------------------------------------------------------------------------------------

            // GS_StockAdjustment => QuantityCorrection
            CreateMap<MessageDto, QuantityCorrection>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_StockAdjustment))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Sku))
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.WarehouseCode))
                .ForPath(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Quantity))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.AdjustmentDate))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Bdcid))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Upos))
                .ForPath(dest => dest.ReasonCode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.AdjustmentReason))
                .ForPath(dest => dest.MovementType, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.BonusNo))
                //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<QuantityCorrection, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_StockAdjustment))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.GS_StockAdjustment.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Quantity, opt => opt.MapFrom(src => src.ActualQty))
                //.ForMember(dest => dest.AdjustmentDate, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Bdcid, opt => opt.MapFrom(src => src.Barcode))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Upos, opt => opt.MapFrom(src => src.Barcode))
                .ForPath(dest => dest.Request.GS_StockAdjustment.AdjustmentReason, opt => opt.MapFrom(src => src.ReasonCode))
                .ForPath(dest => dest.Request.GS_StockAdjustment.BonusNo, opt => opt.MapFrom(src => src.MovementType))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Username))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<MessageDto, QuantityCorrection>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_StockAdjustment))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Sku))
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.WarehouseCode))
                .ForPath(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Quantity))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.AdjustmentDate))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Bdcid))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Upos))
                .ForPath(dest => dest.ReasonCode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.AdjustmentReason))
                .ForPath(dest => dest.MovementType, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.BonusNo))
                //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<QuantityCorrection, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_StockAdjustment))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.GS_StockAdjustment.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Quantity, opt => opt.MapFrom(src => src.ActualQty))
                //.ForMember(dest => dest.AdjustmentDate, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Bdcid, opt => opt.MapFrom(src => src.Barcode))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Upos, opt => opt.MapFrom(src => src.Barcode))
                .ForPath(dest => dest.Request.GS_StockAdjustment.AdjustmentReason, opt => opt.MapFrom(src => src.ReasonCode))
                .ForPath(dest => dest.Request.GS_StockAdjustment.BonusNo, opt => opt.MapFrom(src => src.MovementType))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Username))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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

            // GS_InventorySnapshot => StockReport
            CreateMap<MessageDto, StockReport>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_InventorySnapshot))
                .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.Sku))
                .ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.WarehouseCode))
                .ForMember(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.Quantity))
                .ForMember(dest => dest.LastIncoming, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.LastInductDate))
                .ForMember(dest => dest.LastOutgoing, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.LastRetrievedDate))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<StockReport, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_InventorySnapshot))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.Quantity, opt => opt.MapFrom(src => src.ActualQty))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.LastInductDate, opt => opt.MapFrom(src => src.LastIncoming))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.LastRetrievedDate, opt => opt.MapFrom(src => src.LastOutgoing))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<MessageDto, StockReport>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_InventorySnapshot))
                .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.Sku))
                .ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.WarehouseCode))
                .ForMember(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.Quantity))
                .ForMember(dest => dest.LastIncoming, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.LastInductDate))
                .ForMember(dest => dest.LastOutgoing, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.LastRetrievedDate))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<StockReport, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_InventorySnapshot))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.Quantity, opt => opt.MapFrom(src => src.ActualQty))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.LastInductDate, opt => opt.MapFrom(src => src.LastIncoming))
                .ForMember(dest => dest.Request.GS_InventorySnapshot.LastRetrievedDate, opt => opt.MapFrom(src => src.LastOutgoing))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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

            // GS_PickConfirmation => OutgoingGoodsPositionConfirmation
            CreateMap<MessageDto, OutgoingGoodsPositionConfirmation>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickConfirmation))
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderReference))
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderLineNo))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderLineReference))
                .ForPath(dest => dest.TubNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.ToteId))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.PickedUpos))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickTime))
                //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.ActualQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.DestinationRackNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.DestinationRackPosition, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<OutgoingGoodsPositionConfirmation, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickConfirmation))
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderLineReference, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.ToteId, opt => opt.MapFrom(src => src.TubNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.PickedUpos, opt => opt.MapFrom(src => src.Barcode))
                //.ForMember(dest => dest.BonusNo, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.PickTime, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ActualQty))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationRackNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationRackPosition))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TrolleyNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Destination))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Username))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Name))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<MessageDto, OutgoingGoodsPositionConfirmation>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickConfirmation))
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderReference))
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderLineNo))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderLineReference))
                .ForPath(dest => dest.TubNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.ToteId))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.PickedUpos))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PickTime))
                //.ForMember(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.ActualQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.DestinationRackNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.DestinationRackPosition, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<OutgoingGoodsPositionConfirmation, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickConfirmation))
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderLineReference, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.ToteId, opt => opt.MapFrom(src => src.TubNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.PickedUpos, opt => opt.MapFrom(src => src.Barcode))
                //.ForMember(dest => dest.BonusNo, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.PickTime, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ActualQty))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationRackNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationRackPosition))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TrolleyNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Destination))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Username))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Name))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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

            // GS_ToteAssignment => TubAssignment
            CreateMap<MessageDto, TubAssignment>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ToteAssignment))
                .ForMember(dest => dest.TubNo, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.ToteId))
                .ForMember(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.TrolleyId))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.OrderLineNo))
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.Destination))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationPure))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<TubAssignment, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ToteAssignment))
                .ForMember(dest => dest.Request.GS_ToteAssignment.ToteId, opt => opt.MapFrom(src => src.TubNo))
                .ForMember(dest => dest.Request.GS_ToteAssignment.TrolleyId, opt => opt.MapFrom(src => src.TrolleyNo))
                //.ForMember(dest => dest.Request.GS_ToteAssignment.OrderReference, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_ToteAssignment.OrderLineNo, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Request.GS_ToteAssignment.Destination, opt => opt.MapFrom(src => src.Destination))
                //.ForMember(dest => dest.DestinationPure, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<MessageDto, TubAssignment>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ToteAssignment))
                .ForMember(dest => dest.TubNo, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.ToteId))
                .ForMember(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.TrolleyId))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.OrderLineNo))
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.Destination))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.DestinationPure))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<TubAssignment, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_ToteAssignment))
                .ForMember(dest => dest.Request.GS_ToteAssignment.ToteId, opt => opt.MapFrom(src => src.TubNo))
                .ForMember(dest => dest.Request.GS_ToteAssignment.TrolleyId, opt => opt.MapFrom(src => src.TrolleyNo))
                //.ForMember(dest => dest.Request.GS_ToteAssignment.OrderReference, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_ToteAssignment.OrderLineNo, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Request.GS_ToteAssignment.Destination, opt => opt.MapFrom(src => src.Destination))
                //.ForMember(dest => dest.DestinationPure, opt => opt.MapFrom(src => src.))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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

            //// GS_TrolleyComplete => 
            //CreateMap<MessageDto, ????>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_TrolleyComplete))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TrolleyId))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Totes))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));
            //CreateMap <????, MessageDto >()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_TrolleyComplete))
            //    .ForMember(dest => dest.TrolleyId, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Totes, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));
            //CreateMap <MessageDto, ????> ()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_TrolleyComplete))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TrolleyId))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Totes))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));
            //CreateMap <????, MessageDto >()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_TrolleyComplete))
            //    .ForMember(dest => dest.TrolleyId, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Totes, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));

            // GS_PickCancellation => PickCancelation
            CreateMap<MessageDto, PickCancelation>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellation))
                .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.BonusNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.ReasonCode))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.Cancellations))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<PickCancelation, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellation))
                .ForMember(dest => dest.Request.GS_PickCancellation.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
                //.ForMember(dest => dest.Request.GS_PickCancellation.BonusNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellation.ReasonCode, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellation.Cancellations, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<MessageDto, PickCancelation>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellation))
                .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.BonusNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.ReasonCode))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.Cancellations))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<PickCancelation, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellation))
                .ForMember(dest => dest.Request.GS_PickCancellation.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
                //.ForMember(dest => dest.Request.GS_PickCancellation.BonusNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellation.ReasonCode, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellation.Cancellations, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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

            // GS_PickCancellationRequest => CancelRequest
            CreateMap<MessageDto, CancelRequest>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellationRequest))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.BonusNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.CancellationRequestsDto))
                //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.????))
                //.ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.Request.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<CancelRequest, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellationRequest))
                //.ForMember(dest => dest.Request.GS_PickCancellationRequest.OrderReference, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellationRequest.BonusNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellationRequest.CancellationRequestsDto, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.OutgoingGoodsNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.PositionNo))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<MessageDto, CancelRequest>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
                .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
                .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellationRequest))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.OrderReference))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.BonusNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.CancellationRequestsDto))
                //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.????))
                //.ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.Request.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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
            CreateMap<CancelRequest, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header
                //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
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
                .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
                // Request
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_PickCancellationRequest))
                //.ForMember(dest => dest.Request.GS_PickCancellationRequest.OrderReference, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellationRequest.BonusNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Request.GS_PickCancellationRequest.CancellationRequestsDto, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.OutgoingGoodsNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Request.PositionNo))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
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

            //// GS_Event => 
            //CreateMap<MessageDto, ????>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_Event))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.EventTime))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusActivity))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.WarehouseCode))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));
            //CreateMap <????, MessageDto >()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_Event))
            //    //.ForMember(dest => dest.BonusNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.EventTime, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.BonusActivity, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));
            //CreateMap <MessageDto, ????> ()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForPath(dest => dest.CcuVersion, opt => opt.MapFrom(src => src.Hdr.MessageVersion))
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created))
            //    //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey))
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    //.ForMember(fromErp => fromErp.Status, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Process, opt => opt.MapFrom(src => src.????))
            //    .ForMember(dest => dest.Timestamp.ToString(), opt => opt.MapFrom(src => utcDate.ToString(region)))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_Event))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusNo))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.EventTime))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.BonusActivity))
            //    //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.WarehouseCode))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));
            //CreateMap <????, MessageDto >()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    // Header
            //    //.ForMember(NS_OrderCreate => NS_OrderCreate.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    //.ForMember(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    //.ForPath(dest => dest.Hdr.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion))
            //    .ForPath(dest => dest.Hdr.Created, opt => opt.MapFrom(src => src.Created))
            //    //.ForPath(dest => dest.Hdr.UniqueKey, opt => opt.MapFrom(src => src.RefId))
            //    .ForPath(dest => dest.Hdr.SenderId, opt => opt.MapFrom(src => src.Creator))
            //    //.ForMember(fromErp => fromErp.Hdr.DestinationId, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.Hdr.ResendCounter, opt => opt.MapFrom(src => ????
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Status))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    //.ForMember(fromErp => fromErp.????, opt => opt.MapFrom(src => src.Process))
            //    .ForMember(dest => utcDate.ToString(region), opt => opt.MapFrom(src => src.Timestamp.ToString()))
            //    // Request
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.GS_Event))
            //    //.ForMember(dest => dest.BonusNo, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.EventTime, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.BonusActivity, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(dest => dest.WarehouseCode, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllMembers(x => x.Condition((source, destination, property) =>
            //    {
            //        // Ignore null objects & empty string properties
            //        if (property == null)
            //            return false;
            //        if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property))
            //            return false;
            //        if (property.GetType() == typeof(int) && int.Equals(property, 0))
            //            return false;
            //        if (property.GetType() == typeof(DateTime) && DateTime.Equals(property, "0001-01-01T00:00:00"))
            //            return false;

            //        return true;
            //    }));


            //--------------------------------------------------------------------------------------------
            // List entities
            //--------------------------------------------------------------------------------------------

            // GS_TrolleyCompleteDto > Tote => 
            CreateMap < MessageDto, ????>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ToteId))
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
            CreateMap <????, MessageDto >()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(dest => dest.ToteId, opt => opt.MapFrom(src => src.????))
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
            CreateMap <MessageDto, ????> ()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ToteId))
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
            CreateMap <????, MessageDto >()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(dest => dest.ToteId, opt => opt.MapFrom(src => src.????))
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

            // OrderLine => IncomingGoodsPosition
            CreateMap<MessageDto, IncomingGoodsPosition>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLine))
                .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
                .ForMember(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
                .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PriorityWithinBatch))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.SpecialStockNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.SpecialStockIndicator, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.FiFo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<IncomingGoodsPosition, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(dest => dest.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
                .ForMember(dest => dest.OrderLineReference, opt => opt.MapFrom(src => src.IncomingGoodsNo))
                .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForMember(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ExpirationDate))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockIndicator))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.FiFo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<MessageDto, IncomingGoodsPosition>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLine))
                .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
                .ForMember(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
                .ForMember(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.PriorityWithinBatch))
                //.ForMember(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.SpecialStockNo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.SpecialStockIndicator, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.FiFo, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
                //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<IncomingGoodsPosition, MessageDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForMember(dest => dest.OrderLineNo, opt => opt.MapFrom(src => src.PositionNo))
                .ForMember(dest => dest.OrderLineReference, opt => opt.MapFrom(src => src.IncomingGoodsNo))
                .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForMember(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.????))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.ExpirationDate))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockNo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockIndicator))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.FiFo))
                //.ForMember(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
                //.ForMember(OrderLine => OrderLine.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
                .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// OrderLine => OutgoingGoodsPosition
            //CreateMap<MessageDto, OutgoingGoodsPosition>()
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
            //CreateMap<OutgoingGoodsPosition, MessageDto>()
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
            //CreateMap<MessageDto, OutgoingGoodsPosition>()
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
            //CreateMap<OutgoingGoodsPosition, MessageDto>()
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
            //CreateMap<MessageDto, FromErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLineCancel))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderReference))
            //    //.ForMember(dest => dest.recordType, opt => opt.MapFrom(src => src.OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(OrderLineCancel => OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<MessageDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.OrderLineCancel))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(OrderLineCancel => OrderLineCancel.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// CancellationDto => PickCancelation
            //CreateMap<MessageDto, PickCancelation>()
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
            //CreateMap<FromErp, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Cancellations => Cancellations.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<MessageDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.Cancellation))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(Cancellations => Cancellations.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //// CancellationRequests => CancelRequest
            //CreateMap<MessageDto, RequestCancelation>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancellationRequests))
            //    .ForMember(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference))
            //    .ForMember(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo))
            //    //.ForMember(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<FromErp, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(CancellationRequests => CancellationRequests.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<MessageDto, ToErp>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForMember(fromErp => fromErp.RecordType, opts => opts.MapFrom((src, dest, srcMember) => dest.RecordType = RecordType.CancellationRequests))
            //    //.ForMember(fromErp => fromErp.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = String.Join(',', src.Relation)))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<ToErp, MessageDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    //.ForMember(CancellationRequests => CancellationRequests.Relation, opts => opts.MapFrom((src, dest, srcMember) => dest.Relation = src.Relation.Split(',')))
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

        }
    }
}