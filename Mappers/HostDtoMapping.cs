using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using AutoMapper;

using JsonMessageApi.Models;
using JsonMessageApi.Models.Constants;

using static System.Net.Mime.MediaTypeNames;

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

            // Header - Next header information NOT required for StoreWare
            //// Hdr => HostMessage
            //CreateMap<HdrDto, HostMessage>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    .ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
            //    .ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
            //    .ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
            //    .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
            //    .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
            //    .ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
            //    .ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
            //    .ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
            //    .ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
            //    .ForAllMembers
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            //CreateMap<HostMessage, HdrDto>()
            //    .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
            //    .ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
            //    .ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
            //    .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
            //    .ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
            //    .ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
            //    .ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
            //    .ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
            //    .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
            //    .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
            //    .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
            //    .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
            //    .ForAllOtherMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));


            //--------------------------------------------------------------------------------------------
            // NS = From ERP
            //--------------------------------------------------------------------------------------------

            // NS_ArticleCreate => CreateMaterialMaster
            CreateMap<MessageFromErpDto, CreateMaterialMaster>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Sku))
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.WarehouseCode))
                .ForPath(dest => dest.Description, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.Description))
                .ForPath(dest => dest.UserActivity, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.BonusActivity.ToString())) // Add
                .ForPath(dest => dest.AbcArea, opt => opt.MapFrom(src => src.Request.Ns_ArticleCreate.HotZoneClassification))
                .ForPath(dest => dest.PackagingUnit, opt => opt.MapFrom(src => PackagingUnit.Pcs)) // Default to be entered here = pcs
                .ForPath(dest => dest.IsLotNoRequired, opt => opt.MapFrom(src => false)) // Default to be entered here = false
                .ForPath(dest => dest.Client, opt => opt.MapFrom(src => DefaultValues.DefaultClient)) // Default to be entered here = defaultClient
                .ForPath(dest => dest.Variant, opt => opt.MapFrom(src => DefaultValues.DefaultVariant)) // Default to be entered here = defaultVariant
                //.ForPath(dest => dest.Subdescription1, opt => opt.MapFrom(src => src.????)) // blank
                //.ForPath(dest => dest.Subdescription2, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Subdescription3, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Subdescription4, opt => opt.MapFrom(src => src.????))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));
            CreateMap<CreateMaterialMaster, MessageFromErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.Ns_ArticleCreate.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                .ForPath(dest => dest.Request.Ns_ArticleCreate.Description, opt => opt.MapFrom(src => src.Description))
                .ForPath(dest => dest.Request.Ns_ArticleCreate.BonusActivity, opt => opt.MapFrom(src => long.Parse(src.UserActivity))) // Add
                .ForPath(dest => dest.Request.Ns_ArticleCreate.HotZoneClassification, opt => opt.MapFrom(src => src.AbcArea))
                //.ForPath(dest => PackagingUnit.Pcs, opt => opt.MapFrom(src => src.PackagingUnit)) // Default to be entered here = pcs
                //.ForPath(dest => false, opt => opt.MapFrom(src => src.IsLotNoRequired)) // Default to be entered here = false
                //.ForPath(dest => DefaultValues.DefaultClient, opt => opt.MapFrom(src => src.Client)) // Default to be entered here = defaultClient
                //.ForPath(dest => DefaultValues.DefaultVariant, opt => opt.MapFrom(src => src.Variant)) // Default to be entered here = defaultVariant
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription1))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription2))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription3))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Subdescription4))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));

            // NS_OrderCreate => OutgoingGoods
            CreateMap<MessageFromErpDto, OutgoingGoods>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.OrderReference))
            //.ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.BatchReference)) // Add // String to Long
            //.ForPath(dest => dest.Destination, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.Destination)) // Add // String to Long
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.WarehouseCode))
                .ForPath(dest => dest.BatchPriorityTime, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.PickByTime))
            //.ForPath(dest => dest.BatchPriority, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.BatchPriority)) // String to Int
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.BatchDescription)) // Required?
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.BatchEndAllowed)) // Add
                .ForPath(dest => dest.Positions, opt => opt.MapFrom(src => src.Request.NS_OrderCreate.OrderLines))
                //.ForPath(dest => dest.Client, opt => opt.MapFrom(src => src.????)) // Default client
                //.ForPath(dest => dest.MovementType, opt => opt.MapFrom(src => src.????)) // Default enum.OutgoingPlanned
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));
            CreateMap<OutgoingGoods, MessageFromErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.NS_OrderCreate.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
            //.ForPath(dest => dest.Request.NS_OrderCreate.BatchReference, opt => opt.MapFrom(src => src.BatchId)) // Add // String to Long
            //.ForPath(dest => dest.Request.NS_OrderCreate.Destination, opt => opt.MapFrom(src => src.Destination)) // Add // String to Long
                .ForPath(dest => dest.Request.NS_OrderCreate.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                .ForPath(dest => dest.Request.NS_OrderCreate.PickByTime, opt => opt.MapFrom(src => src.BatchPriorityTime))
            //.ForPath(dest => dest.Request.NS_OrderCreate.BatchPriority, opt => opt.MapFrom(src => src.BatchPriority)) // Add // String to Int
                //.ForPath(dest => dest.BatchDescription, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.BatchEndAllowed, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.Request.NS_OrderCreate.OrderLines, opt => opt.MapFrom(src => src.Positions))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Client))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));

            // NS_OrderUpdate => MAKE NEW MODEL -> OrderUpdate
            CreateMap<MessageFromErpDto, OrderUpdate>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.NS_OrderUpdate.OrderReference))
                .ForPath(dest => dest.PickByTime, opt => opt.MapFrom(src => src.Request.NS_OrderUpdate.PickByTime))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));
            CreateMap <OrderUpdate, MessageFromErpDto >()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.NS_OrderUpdate.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
                .ForPath(dest => dest.Request.NS_OrderUpdate.PickByTime, opt => opt.MapFrom(src => src.PickByTime))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));

            //// NS_OrderCancel => MAKE NEW MODEL -> OrderCancel
            CreateMap<MessageFromErpDto, OrderCancel>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.NS_OrderCancel.OrderReference))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));
            CreateMap<OrderCancel, MessageFromErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.NS_OrderCancel.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));

            // NS_OrderLineCancel => MAKE NEW MODEL -> OrderLineCancel
            CreateMap<MessageFromErpDto, OrderLineCancel>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.OutgoingGoodsPositionNo, opt => opt.MapFrom(src => src.Request.NS_OrderLineCancel.OrderReference))
                .ForPath(dest => dest.Positions, opt => opt.MapFrom(src => src.Request.NS_OrderLineCancel.OrderLineCancel))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));
            CreateMap <OrderLineCancel, MessageFromErpDto > ()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.NS_OrderLineCancel.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsPositionNo))
                .ForPath(dest => dest.Request.NS_OrderLineCancel.OrderLineCancel, opt => opt.MapFrom(src => src.Positions))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));

            // NS_ValidationError => NEW MODEL - ValidationErrorFromErp
            CreateMap< MessageFromErpDto, ValidationErrorFromErp> ()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                //Request
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.NS_ValidationError.OrderReference))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));
            CreateMap<ValidationErrorFromErp, MessageFromErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.NS_ValidationError.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
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
                    if (property.GetType() == typeof(RecordType) && RecordType.Equals(property, 0))
                        return false;

                    return true;
                }));

            //--------------------------------------------------------------------------------------------
            // GS = To ERP
            //--------------------------------------------------------------------------------------------

            // GS_StockAdjustment => QuantityCorrection
            CreateMap<MessageToErpDto, QuantityCorrection>(MemberList.None)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Sku))
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.WarehouseCode))
                //.ForPath(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Quantity)) // +/-
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.AdjustmentDate))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Bdcid))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.Upos))
                //.ForPath(dest => dest.ReasonCode, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.AdjustmentReason.ToString()))
                //.ForPath(dest => dest.MovementType, opt => opt.MapFrom(src => src.????)) // Ignore
                //.ForPath(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????)) // Expected amount
                .ForPath(dest => dest.Username, opt => opt.MapFrom(src => src.Request.GS_StockAdjustment.BonusNo))
                .ReverseMap()
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
            CreateMap<QuantityCorrection, MessageToErpDto>(MemberList.None)
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                //.ForPath(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                //.ForPath(dest => dest.Request.GS_StockAdjustment.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.GS_StockAdjustment.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                //.ForPath(dest => dest.Request.GS_StockAdjustment.Quantity, opt => opt.MapFrom(src => src.ActualQty)) // +/-
                .ForPath(dest => dest.Request.GS_StockAdjustment.AdjustmentDate, opt => opt.MapFrom(src => src.Created))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Bdcid, opt => opt.MapFrom(src => src.Barcode))
                .ForPath(dest => dest.Request.GS_StockAdjustment.Upos, opt => opt.MapFrom(src => src.Barcode))
                //.ForPath(dest => dest.Request.GS_StockAdjustment.AdjustmentReason, opt => opt.MapFrom(src => long.Parse(src.ReasonCode)))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.MovementType)) // Ignore
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty)) // Expected amount
                .ForPath(dest => dest.Request.GS_StockAdjustment.BonusNo, opt => opt.MapFrom(src => src.Username))
                .ReverseMap()
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
            CreateMap<MessageToErpDto, StockReport>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.Sku))
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.WarehouseCode))
                .ForPath(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.Quantity))
                .ForPath(dest => dest.LastIncoming, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.LastInductDate))
                .ForPath(dest => dest.LastOutgoing, opt => opt.MapFrom(src => src.Request.GS_InventorySnapshot.LastRetrievedDate))
                .ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate))
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
            CreateMap<StockReport, MessageToErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.GS_InventorySnapshot.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.GS_InventorySnapshot.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
                .ForPath(dest => dest.Request.GS_InventorySnapshot.Quantity, opt => opt.MapFrom(src => src.ActualQty))
                .ForPath(dest => dest.Request.GS_InventorySnapshot.LastInductDate, opt => opt.MapFrom(src => src.LastIncoming))
                .ForPath(dest => dest.Request.GS_InventorySnapshot.LastRetrievedDate, opt => opt.MapFrom(src => src.LastOutgoing))
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
            CreateMap<MessageToErpDto, OutgoingGoodsPositionConfirmation>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderReference))
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderLineReference.ToString()))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.OrderLineNo)) // What is this?
                //.ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.TubNo, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.ToteId.ToString()))
                .ForPath(dest => dest.Barcode, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.PickedUpos))
                .ForPath(dest => dest.Username, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.BonusNo))
                .ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.PickTime))
                //.ForPath(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.TargetQty, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.ActualQty, opt => opt.MapFrom(src => src.Request.GS_PickConfirmation.Qty))
                //.ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.DestinationRackNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.DestinationRackPosition, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Destination, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Name, opt => opt.MapFrom(src => src.????))
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
            CreateMap<OutgoingGoodsPositionConfirmation, MessageToErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.OrderLineReference, opt => opt.MapFrom(src => long.Parse(src.PositionNo))) // What is this?
                //.ForPath(dest => dest.Request.GS_PickConfirmation.OrderLineNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Request.GS_PickConfirmation.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                .ForPath(dest => dest.Request.GS_PickConfirmation.ToteId, opt => opt.MapFrom(src => long.Parse(src.TubNo)))
                .ForPath(dest => dest.Request.GS_PickConfirmation.PickedUpos, opt => opt.MapFrom(src => src.Barcode))
                .ForPath(dest => dest.Request.GS_PickConfirmation.BonusNo, opt => opt.MapFrom(src => src.Username))
                .ForPath(dest => dest.Request.GS_PickConfirmation.PickTime, opt => opt.MapFrom(src => src.Created))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.TargetQty))
                .ForPath(dest => dest.Request.GS_PickConfirmation.Qty, opt => opt.MapFrom(src => src.ActualQty))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.DestinationRackNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.DestinationRackPosition))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.TrolleyNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Destination))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Username))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Name))
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
            CreateMap<MessageToErpDto, TubAssignment>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.TubNo, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.ToteId.ToString()))
                .ForPath(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.TrolleyId.ToString()))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.OrderReference)) // Do Next need this?
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.OrderLineNo)) // Do Next need this?
                //.ForPath(dest => dest.Destination, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.Destination))
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_ToteAssignment.Destination.ToString()))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.DestinationPure)) // TBC - For batch end tails
                //.ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.????)) // Do Next need this?
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
            CreateMap<TubAssignment, MessageToErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.GS_ToteAssignment.ToteId, opt => opt.MapFrom(src => long.Parse(src.TubNo)))
                .ForPath(dest => dest.Request.GS_ToteAssignment.TrolleyId, opt => opt.MapFrom(src => long.Parse(src.TrolleyNo)))
                //.ForPath(dest => dest.Request.GS_ToteAssignment.OrderReference, opt => opt.MapFrom(src => src.????)) // Do Next need this?
                //.ForPath(dest => dest.Request.GS_ToteAssignment.OrderLineNo, opt => opt.MapFrom(src => src.????)) // Do Next need this?
                //.ForPath(dest => dest.Request.GS_ToteAssignment.Destination, opt => opt.MapFrom(src => src.Destination))
                .ForPath(dest => dest.Request.GS_ToteAssignment.Destination, opt => opt.MapFrom(src => long.Parse(src.StorageArea)))
                //.ForPath(dest => dest.DestinationPure, opt => opt.MapFrom(src => src.)) // TBC - For batch end tails
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.BatchId)) // Do Next need this?
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

            // GS_TrolleyComplete => MAKE NEW MODEL
            CreateMap<MessageToErpDto, TrolleyComplete> ()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                //Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.TrolleyId, opt => opt.MapFrom(src => src.Request.GS_TrolleyComplete.TrolleyId))
                .ForPath(dest => dest.TubPositions, opt => opt.MapFrom(src => src.Request.GS_TrolleyComplete.Totes))
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
            CreateMap<TrolleyComplete, MessageToErpDto> ()
               .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
               // Header - Next header information NOT required for StoreWare
               //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
               //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
               //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
               //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
               //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
               //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
               // Request
               .ForPath(dest => dest.Request.GS_TrolleyComplete.TrolleyId, opt => opt.MapFrom(src => src.TrolleyId))
               .ForPath(dest => dest.Request.GS_TrolleyComplete.Totes, opt => opt.MapFrom(src => src.TubPositions))
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

            // GS_PickCancellation => PickCancelation
            CreateMap<MessageToErpDto, PickCancelation>()
               .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
               // Header - Next header information NOT required for StoreWare
               //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
               //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
               //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
               //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
               //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
               //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
               //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
               // Request
               .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.OrderReference))
               .ForPath(dest => dest.Username, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.BonusNo)) // Add username
               .ForPath(dest => dest.ReasonCode, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.ReasonCode.ToString()))
               .ForPath(dest => dest.Positions, opt => opt.MapFrom(src => src.Request.GS_PickCancellation.Cancellations))
               //.ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
               //.ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.????))
               //.ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.????))
               //.ForPath(dest => dest.CancelQty, opt => opt.MapFrom(src => src.????))
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
           CreateMap<PickCancelation, MessageToErpDto>()
               .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
               // Header - Next header information NOT required for StoreWare
               //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
               //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
               //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
               //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
               //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
               //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
               // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
               // Request
               .ForPath(dest => dest.Request.GS_PickCancellation.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
               .ForPath(dest => dest.Request.GS_PickCancellation.BonusNo, opt => opt.MapFrom(src => src.Username)) // Add username
               .ForPath(dest => dest.Request.GS_PickCancellation.ReasonCode, opt => opt.MapFrom(src => long.Parse(src.ReasonCode)))
               .ForPath(dest => dest.Request.GS_PickCancellation.Cancellations, opt => opt.MapFrom(src => src.Positions))
               //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
               //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.PositionNo))
               //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.ArticleNo))
               //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.CancelQty))
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
           CreateMap<MessageToErpDto, CancelRequest>()
               .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
               // Header - Next header information NOT required for StoreWare
               //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
               //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
               //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
               //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
               //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
               //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
               //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
               //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
               //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
               // Request
               .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.OrderReference)) // Add
               .ForPath(dest => dest.Username, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.BonusNo)) // Add
               .ForPath(dest => dest.CancelRequestPositions, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.CancellationRequests))
               .ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.Request.GS_PickCancellationRequest.BatchReference)) // Required in Next system
               //.ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.????)) // Required in Next system CancellationRequestsDtoCancellationRequestsDto.OrderLineNo
               //.ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.Request.????))// Required in Next system (should be in each cancellation) CancellationRequestsDto.OrderLineReference
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
            CreateMap<CancelRequest, MessageToErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.GS_PickCancellationRequest.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo)) // Add
                .ForPath(dest => dest.Request.GS_PickCancellationRequest.BonusNo, opt => opt.MapFrom(src => src.Username)) // Add
                .ForPath(dest => dest.Request.GS_PickCancellationRequest.CancellationRequests, opt => opt.MapFrom(src => src.CancelRequestPositions))
                .ForPath(dest => dest.Request.GS_PickCancellationRequest.BatchReference, opt => opt.MapFrom(src => src.BatchId)) // Required in Next system
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Request.OutgoingGoodsNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Request.PositionNo))
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

            // GS_Activity => MAKE NEW MODEL
            CreateMap<MessageToErpDto, SystemActivity> ()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.Username, opt => opt.MapFrom(src => src.Request.GS_Activity.BonusNo))
                .ForPath(dest => dest.EventTime, opt => opt.MapFrom(src => src.Request.GS_Activity.EventTime))
                .ForPath(dest => dest.UserActivity, opt => opt.MapFrom(src => src.Request.GS_Activity.BonusActivity))
                .ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.Request.GS_Activity.WarehouseCode))
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
            CreateMap <SystemActivity, MessageToErpDto> ()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.GS_Activity.BonusNo, opt => opt.MapFrom(src => src.Username))
                .ForPath(dest => dest.Request.GS_Activity.EventTime, opt => opt.MapFrom(src => src.EventTime))
                .ForPath(dest => dest.Request.GS_Activity.BonusActivity, opt => opt.MapFrom(src => src.UserActivity))
                .ForPath(dest => dest.Request.GS_Activity.WarehouseCode, opt => opt.MapFrom(src => src.StorageArea))
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

            // GS_ValidationError => MAKE NEW MODEL -> ValidationErrorToErp
            CreateMap<MessageToErpDto, ValidationErrorToErp>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.CcuVersion, opts => opts.MapFrom(src => src.Hdr.MessageVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Hdr.Created)) // Internal only
                //.ForPath(dest => dest.RefId, opt => opt.MapFrom(src => src.Hdr.UniqueKey)) // Ref id is for additional relations
                //.ForPath(dest => dest.Creator, opt => opt.MapFrom(src => src.Hdr.SenderId)) // Internal only
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.DestinationId))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Hdr.ResendCounter))
                //.ForPath(fromErp => dest.Status, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ErrorInterface, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.Process, opt => opt.MapFrom(src => src.????)) // Internal only
                //.ForPath(dest => dest.Timestamp, opt => opt.MapFrom(src => utcDate)) // Internal only
                // Request
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.Request.GS_ValidationError.OrderReference))
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
            CreateMap<ValidationErrorToErp, MessageToErpDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                // Header - Next header information NOT required for StoreWare
                //.ForPath(dest => dest.MessageType, opt => opt.MapFrom(src => src.recordType))
                //.ForPath(dest => dest.MessageVersion, opt => opt.MapFrom(src => src.CcuVersion)) // Zero for original version, // Internal only
                //.ForPath(dest => dest.Created, opt => opt.MapFrom(src => src.Created)) // Internal only
                //.ForPath(dest => dest.UniqueKey, opt => opt.MapFrom(src => src.RefId)) // Ref id is for additional relations
                //.ForPath(dest => dest.SenderId, opt => opt.MapFrom(src => src.Creator)) // Internal only
                //.ForPath(fromErp => dest.DestinationId, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.ResendCounter, opt => opt.MapFrom(src => src.????))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Status))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.ErrorInterface))
                //.ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Process)) // Internal only
                // .ForPath(fromErp => dest.????, opt => opt.MapFrom(src => src.Timestamp)) // Internal only
                // Request
                .ForPath(dest => dest.Request.GS_ValidationError.OrderReference, opt => opt.MapFrom(src => src.OutgoingGoodsNo))
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

            //--------------------------------------------------------------------------------------------
            // List entities
            //--------------------------------------------------------------------------------------------

            // GS_TrolleyCompleteDto > Tote(tub) => TubAssignment
            CreateMap<ToteDto, TubPosition>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.TubNo, opt => opt.MapFrom(src => src.ToteId.ToString()))
                //.ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.TrolleyNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Destination, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.????))
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
            CreateMap<TubPosition, ToteDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.ToteId, opt => opt.MapFrom(src => long.Parse(src.TubNo)))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.TrolleyNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Destination))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.BatchId))
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

            // N/A > OrderLine => IncomingGoodsPosition
            CreateMap<OrderLineDto, IncomingGoodsPosition>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo.ToString()))
                .ForPath(dest => dest.IncomingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference.ToString()))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.PriorityWithinBatch))
                //.ForPath(dest => dest.StorageArea, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.ExpirationDate, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.SpecialStockNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.SpecialStockIndicator, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.FiFo, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.TargetQty, opt => opt.MapFrom(src => src.Qty))
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
            CreateMap<IncomingGoodsPosition, OrderLineDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.OrderLineNo, opt => opt.MapFrom(src => long.Parse(src.PositionNo)))
                .ForPath(dest => dest.OrderLineReference, opt => opt.MapFrom(src => long.Parse(src.IncomingGoodsNo)))
                .ForPath(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForPath(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.StorageArea))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.ExpirationDate))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.SpecialStockIndicator))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.FiFo))
                .ForPath(dest => dest.Qty, opt => opt.MapFrom(src => src.TargetQty))
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

            // NS_OrderCreateDto > OrderLine => OutgoingGoodsPosition
            CreateMap<OrderLineDto, OutgoingGoodsPosition>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo.ToString()))
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference.ToString()))
                .ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.Sku))
                //.ForPath(dest => dest.Destination, opt => opt.MapFrom(src => src.PriorityWithinBatch))
                //.ForPath(dest => dest.MovementType, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.LotNo, opt => opt.MapFrom(src => src.????))
                .ForPath(dest => dest.TargetQty, opt => opt.MapFrom(src => src.Qty))
                //.ForPath(dest => dest.Client, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.Variant, opt => opt.MapFrom(src => src.????))
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
            CreateMap<OutgoingGoodsPosition, OrderLineDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.OrderLineNo, opt => opt.MapFrom(src => long.Parse(src.PositionNo)))
                .ForPath(dest => dest.OrderLineReference, opt => opt.MapFrom(src => long.Parse(src.OutgoingGoodsNo)))
                .ForPath(dest => dest.Sku, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForPath(dest => dest.PriorityWithinBatch, opt => opt.MapFrom(src => src.Destination))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.MovementType))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.LotNo))
                .ForPath(dest => dest.Qty, opt => opt.MapFrom(src => src.TargetQty))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Client))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.Variant))
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

            // NS_OrderLineCancelDto > OrderLineCancel => CancelRequest
            CreateMap<OrderLineCancelDto, CancelRequest>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo.ToString()))
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference.ToString()))
                .ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.BatchReference))
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
            CreateMap<CancelRequest, OrderLineCancelDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.OrderLineNo, opt => opt.MapFrom(src => long.Parse(src.PositionNo)))
                .ForPath(dest => dest.OrderLineReference, opt => opt.MapFrom(src => long.Parse(src.OutgoingGoodsNo)))
                .ForPath(dest => dest.BatchReference, opt => opt.MapFrom(src => src.BatchId))
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

            // GS_PickCancellationDto > CancellationDto => PickCancelation
            CreateMap<CancellationDto, PickCancelation>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference.ToString())) // Add
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo.ToString())) // Add
                .ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.BatchReference))
                //.ForPath(dest => dest.ArticleNo, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.CancelQty, opt => opt.MapFrom(src => src.????))
                //.ForPath(dest => dest.ReasonCode, opt => opt.MapFrom(src => src.????))
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
            CreateMap<PickCancelation, CancellationDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.OrderLineReference, opt => opt.MapFrom(src => long.Parse(src.OutgoingGoodsNo))) // Add
                .ForPath(dest => dest.BatchReference, opt => opt.MapFrom(src => long.Parse(src.BatchId))) // Add
                .ForPath(dest => dest.BatchReference, opt => opt.MapFrom(src => src.BatchId))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.ArticleNo))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.CancelQty))
                //.ForPath(dest => dest.????, opt => opt.MapFrom(src => src.ReasonCode))
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

            // GS_PickCancellationRequestDto > CancellationRequests => CancelRequest
            CreateMap<CancellationRequestsDto, RequestCancelation>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.OutgoingGoodsNo, opt => opt.MapFrom(src => src.OrderLineReference.ToString()))
                .ForPath(dest => dest.PositionNo, opt => opt.MapFrom(src => src.OrderLineNo.ToString()))
                .ForPath(dest => dest.BatchId, opt => opt.MapFrom(src => src.BatchReference)) // Add
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
            CreateMap<RequestCancelation, CancellationRequestsDto>()
                .IgnoreAllSourcePropertiesWithAnInaccessibleSetter().IgnoreAllPropertiesWithAnInaccessibleSetter()
                .ForPath(dest => dest.OrderLineReference, opt => opt.MapFrom(src => long.Parse(src.OutgoingGoodsNo)))
                .ForPath(dest => dest.OrderLineNo, opt => opt.MapFrom(src => long.Parse(src.PositionNo)))
                .ForPath(dest => dest.BatchReference, opt => opt.MapFrom(src => src.BatchId)) // Add
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
        }
    }
}