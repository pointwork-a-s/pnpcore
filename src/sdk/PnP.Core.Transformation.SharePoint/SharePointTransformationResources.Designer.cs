﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PnP.Core.Transformation.SharePoint {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SharePointTransformationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SharePointTransformationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PnP.Core.Transformation.SharePoint.SharePointTransformationResources", typeof(SharePointTransformationResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Combining mapping data.
        /// </summary>
        internal static string Debug_CombiningMappingData {
            get {
                return ResourceManager.GetString("Debug_CombiningMappingData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing selector functions.
        /// </summary>
        internal static string Debug_ProcessingSelectorFunctions {
            get {
                return ResourceManager.GetString("Debug_ProcessingSelectorFunctions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Principal Input: {0}.
        /// </summary>
        internal static string Debug_UserTransformPrincipalInput {
            get {
                return ResourceManager.GetString("Debug_UserTransformPrincipalInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred cleaning extracted web part fields.
        /// </summary>
        internal static string Error_AnalyserCleaningExtractedWebPartFields {
            get {
                return ResourceManager.GetString("Error_AnalyserCleaningExtractedWebPartFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GetAllPageLayouts - Could not search for page layouts.
        /// </summary>
        internal static string Error_AnalyserCouldNotFindLayouts {
            get {
                return ResourceManager.GetString("Error_AnalyserCouldNotFindLayouts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred extracting html blocks from page layout html.
        /// </summary>
        internal static string Error_AnalyserErrorOccurredExtractHtmlBlocks {
            get {
                return ResourceManager.GetString("Error_AnalyserErrorOccurredExtractHtmlBlocks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An issue occurred with extracting metadata from page layout.
        /// </summary>
        internal static string Error_AnalyserErrorOccurredExtractMetadata {
            get {
                return ResourceManager.GetString("Error_AnalyserErrorOccurredExtractMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred extracting web part prefixes from namespaces.
        /// </summary>
        internal static string Error_AnalyserErrorOccurredExtractNamespaces {
            get {
                return ResourceManager.GetString("Error_AnalyserErrorOccurredExtractNamespaces", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred extract page header from page layout associated content type.
        /// </summary>
        internal static string Error_AnalyserExtractPageHeaderFromPageLayout {
            get {
                return ResourceManager.GetString("Error_AnalyserExtractPageHeaderFromPageLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No web parts were found on page &apos;{0}&apos;.
        /// </summary>
        internal static string Error_AnalysingNoWebPartsFound {
            get {
                return ResourceManager.GetString("Error_AnalysingNoWebPartsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred processing functions.
        /// </summary>
        internal static string Error_AnErrorOccurredFunctions {
            get {
                return ResourceManager.GetString("Error_AnErrorOccurredFunctions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Asset was not transferred. Asset: {0}.
        /// </summary>
        internal static string Error_AssetTransferFailedFallback {
            get {
                return ResourceManager.GetString("Error_AssetTransferFailedFallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source page &apos;{0}&apos; is a basic ASPX page ... can&apos;t currently transform that one, sorry!.
        /// </summary>
        internal static string Error_BasicASPXPageCannotTransform {
            get {
                return ResourceManager.GetString("Error_BasicASPXPageCannotTransform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Blog pages cannot be transformed in-place, their target site collection must be a different one..
        /// </summary>
        internal static string Error_BlogPageTransformationHasToBeCrossSite {
            get {
                return ResourceManager.GetString("Error_BlogPageTransformationHasToBeCrossSite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error calling Web Services to Extract Web Parts from page &apos;{0}&apos;.
        /// </summary>
        internal static string Error_CallingWebServicesToExtractWebPartsFromPage {
            get {
                return ResourceManager.GetString("Error_CallingWebServicesToExtractWebPartsFromPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred casting value to enum.
        /// </summary>
        internal static string Error_CannotCastToEnum {
            get {
                return ResourceManager.GetString("Error_CannotCastToEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get site collection context.
        /// </summary>
        internal static string Error_CannotGetSiteCollContext {
            get {
                return ResourceManager.GetString("Error_CannotGetSiteCollContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot map the metadata fields from the content types.
        /// </summary>
        internal static string Error_CannotMapMetadataFields {
            get {
                return ResourceManager.GetString("Error_CannotMapMetadataFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error mapping page layout - Analyse.
        /// </summary>
        internal static string Error_CannotProcessPageLayoutAnalyse {
            get {
                return ResourceManager.GetString("Error_CannotProcessPageLayoutAnalyse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error mapping page layout - Analyse All.
        /// </summary>
        internal static string Error_CannotProcessPageLayoutAnalyseAll {
            get {
                return ResourceManager.GetString("Error_CannotProcessPageLayoutAnalyseAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error writing to mapping file: {0} {1}.
        /// </summary>
        internal static string Error_CannotWriteToXmlFile {
            get {
                return ResourceManager.GetString("Error_CannotWriteToXmlFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ExecuteQuery threw following exception: {0}..
        /// </summary>
        internal static string Error_ClientContextExtensions_ExecuteQueryRetryException {
            get {
                return ResourceManager.GetString("Error_ClientContextExtensions_ExecuteQueryRetryException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Url of the site is required..
        /// </summary>
        internal static string Error_Clone_Context_Url_Required {
            get {
                return ResourceManager.GetString("Error_Clone_Context_Url_Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CSOM request socket exception. Retry attempt {0}. Sleeping for {1} milliseconds before retrying..
        /// </summary>
        internal static string Error_CSOMRequestSocketException {
            get {
                return ResourceManager.GetString("Error_CSOMRequestSocketException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred in DocumentEmbedLookup function: {0}.
        /// </summary>
        internal static string Error_DocumentEmbedLookup {
            get {
                return ResourceManager.GetString("Error_DocumentEmbedLookup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred in DocumentEmbedLookup function - file not retrievable - {0}.
        /// </summary>
        internal static string Error_DocumentEmbedLookupFileNotRetrievable {
            get {
                return ResourceManager.GetString("Error_DocumentEmbedLookupFileNotRetrievable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to ensure user exists: {0}.
        /// </summary>
        internal static string Error_GetPrincipalFailedEnsureUser {
            get {
                return ResourceManager.GetString("Error_GetPrincipalFailedEnsureUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Body contents was set to null, this is an invalid and empty blog page: &apos;{0}&apos;.
        /// </summary>
        internal static string Error_InvalidOrMissingBlogContent {
            get {
                return ResourceManager.GetString("Error_InvalidOrMissingBlogContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WikiField contents was set to null, this is an invalid and empty wiki page: &apos;{0}&apos;.
        /// </summary>
        internal static string Error_InvalidOrMissingWikiContent {
            get {
                return ResourceManager.GetString("Error_InvalidOrMissingWikiContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid source context for exporting content.
        /// </summary>
        internal static string Error_InvalidSourceContext {
            get {
                return ResourceManager.GetString("Error_InvalidSourceContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid input for the SharePointWebPartMappingProvider.
        /// </summary>
        internal static string Error_InvalidWebPartMappingProviderInput {
            get {
                return ResourceManager.GetString("Error_InvalidWebPartMappingProviderInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred in LoadContentFromFile function: {0}.
        /// </summary>
        internal static string Error_LoadContentFromFile {
            get {
                return ResourceManager.GetString("Error_LoadContentFromFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred in getting the referenced file in content link: {0}.
        /// </summary>
        internal static string Error_LoadContentFromFileContentLink {
            get {
                return ResourceManager.GetString("Error_LoadContentFromFileContentLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Publishing transformation layout mapping can maximum use 3 columns.
        /// </summary>
        internal static string Error_Maximum3ColumnsAllowed {
            get {
                return ResourceManager.GetString("Error_Maximum3ColumnsAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The media web part configuration could not be read, skipping this web part from the transformation.
        /// </summary>
        internal static string Error_MediaWebpartConfiguration {
            get {
                return ResourceManager.GetString("Error_MediaWebpartConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Media web part configuration did not allow to read it&apos;s settings. Did you check if there was a preview image set?.
        /// </summary>
        internal static string Error_MediaWebPartNotProperlyConfigured {
            get {
                return ResourceManager.GetString("Error_MediaWebPartNotProperlyConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid empty string argument.
        /// </summary>
        internal static string Error_Message_EmptyString_Arg {
            get {
                return ResourceManager.GetString("Error_Message_EmptyString_Arg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SharePoint input item is missing.
        /// </summary>
        internal static string Error_MissiningSharePointInputItem {
            get {
                return ResourceManager.GetString("Error_MissiningSharePointInputItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No default mapping was found int the provided mapping file.
        /// </summary>
        internal static string Error_NoDefaultMappingFound {
            get {
                return ResourceManager.GetString("Error_NoDefaultMappingFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No valid PageLayout transformation model could be retrieved for publishing page layout &apos;{0}&apos; of page &apos;{1}&apos;.
        /// </summary>
        internal static string Error_NoPageLayoutTransformationModel {
            get {
                return ResourceManager.GetString("Error_NoPageLayoutTransformationModel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NotAvailableAtTargetException is used to &quot;skip&quot; a web part since it&apos;s not valid for the target site collection (only applies to cross site collection transfers).
        /// </summary>
        internal static string Error_NotValidForTargetSiteCollection {
            get {
                return ResourceManager.GetString("Error_NotValidForTargetSiteCollection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided custom pagelayout mapping file is invalid: {0}.
        /// </summary>
        internal static string Error_PageLayoutMappingFileSchemaValidation {
            get {
                return ResourceManager.GetString("Error_PageLayoutMappingFileSchemaValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page &apos;{0}&apos; is not valid due to missing FileRef or FileLeafRef value.
        /// </summary>
        internal static string Error_PageNotValidMissingFileRef {
            get {
                return ResourceManager.GetString("Error_PageNotValidMissingFileRef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Issue while retrieving the new location for the asset. Asset: {0}.
        /// </summary>
        internal static string Error_ReturnCrossSiteRelativePathFailedFallback {
            get {
                return ResourceManager.GetString("Error_ReturnCrossSiteRelativePathFailedFallback", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source page &apos;{0}&apos; is already a modern page.
        /// </summary>
        internal static string Error_SourcePageIsModern {
            get {
                return ResourceManager.GetString("Error_SourcePageIsModern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source page &apos;{0}&apos; cannot be null.
        /// </summary>
        internal static string Error_SourcePageNotFound {
            get {
                return ResourceManager.GetString("Error_SourcePageNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported version of SharePoint as the source of transformation.
        /// </summary>
        internal static string Error_UnsupportedSourceVersion {
            get {
                return ResourceManager.GetString("Error_UnsupportedSourceVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided custom web part mapping file is invalid: {0}.
        /// </summary>
        internal static string Error_WebPartMappingSchemaValidation {
            get {
                return ResourceManager.GetString("Error_WebPartMappingSchemaValidation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XML definition for web part &apos;{0}&apos; from page &apos;{1}&apos; was not exportable. Exception: {2}..
        /// </summary>
        internal static string Error_WebPartXmlNotExported {
            get {
                return ResourceManager.GetString("Error_WebPartXmlNotExported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Added &apos;Client Side Text Web Part&apos; to target page.
        /// </summary>
        internal static string Info_AddedClientSideTextWebPart {
            get {
                return ResourceManager.GetString("Info_AddedClientSideTextWebPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found {0} page layouts.
        /// </summary>
        internal static string Info_AnalyserFoundItems {
            get {
                return ResourceManager.GetString("Info_AnalyserFoundItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating mapping for `{0}` layout.
        /// </summary>
        internal static string Info_AnalyserMappingLayout {
            get {
                return ResourceManager.GetString("Info_AnalyserMappingLayout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are no page layouts found to analyse.
        /// </summary>
        internal static string Info_AnalyserNoLayoutsFound {
            get {
                return ResourceManager.GetString("Info_AnalyserNoLayoutsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling Web Services to Extract Web Parts from page &apos;{0}&apos;.
        /// </summary>
        internal static string Info_CallingWebServicesToExtractWebPartsFromPage {
            get {
                return ResourceManager.GetString("Info_CallingWebServicesToExtractWebPartsFromPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source page &apos;{0}&apos; contains web part &apos;{1}&apos; of type &apos;{2}&apos;.
        /// </summary>
        internal static string Info_ContentTransformFoundSourceWebParts {
            get {
                return ResourceManager.GetString("Info_ContentTransformFoundSourceWebParts", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using {0} modern web part.
        /// </summary>
        internal static string Info_ContentUsingModernWebPart {
            get {
                return ResourceManager.GetString("Info_ContentUsingModernWebPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Web Part &apos;{0}&apos; of type &apos;{1}&apos; is being transformed.
        /// </summary>
        internal static string Info_ContentWebPartBeingTransformed {
            get {
                return ResourceManager.GetString("Info_ContentWebPartBeingTransformed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item level permissions read.
        /// </summary>
        internal static string Info_GetItemLevelPermissions {
            get {
                return ResourceManager.GetString("Info_GetItemLevelPermissions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Image file {0} temporary persisted as {1}.
        /// </summary>
        internal static string Info_ImageFilePersisted {
            get {
                return ResourceManager.GetString("Info_ImageFilePersisted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not transforming Title Bar - this is not used in modern pages.
        /// </summary>
        internal static string Info_NotTransformingTitleBar {
            get {
                return ResourceManager.GetString("Info_NotTransformingTitleBar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No web parts were found on page &apos;{0}&apos;.
        /// </summary>
        internal static string Info_NoWebPartsFound {
            get {
                return ResourceManager.GetString("Info_NoWebPartsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipped page layout {0} because it&apos;s an OOB page layout.
        /// </summary>
        internal static string Info_OOBPageLayoutSkipped {
            get {
                return ResourceManager.GetString("Info_OOBPageLayoutSkipped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page analysis completed for page &apos;{0}&apos;.
        /// </summary>
        internal static string Info_PageAnalysisComplete {
            get {
                return ResourceManager.GetString("Info_PageAnalysisComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page &apos;{0}&apos; uses &apos;{1}&apos; as page layout, mapping that will be used is {2}.
        /// </summary>
        internal static string Info_PageLayoutMappingBeingUsed {
            get {
                return ResourceManager.GetString("Info_PageLayoutMappingBeingUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page &apos;{0}&apos; uses &apos;{1}&apos; as page layout, no mapping was provided so auto generating a mapping.
        /// </summary>
        internal static string Info_PageLayoutMappingGeneration {
            get {
                return ResourceManager.GetString("Info_PageLayoutMappingGeneration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page &apos;{0}&apos; is loaded from outside a library.
        /// </summary>
        internal static string Info_PageLivesOutsideOfALibrary {
            get {
                return ResourceManager.GetString("Info_PageLivesOutsideOfALibrary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Validation checks completed for page &apos;{0}&apos;.
        /// </summary>
        internal static string Info_PageValidationChecksComplete {
            get {
                return ResourceManager.GetString("Info_PageValidationChecksComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Processing mapping functions.
        /// </summary>
        internal static string Info_ProcessingMappingFunctions {
            get {
                return ResourceManager.GetString("Info_ProcessingMappingFunctions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving Web Part &apos;{0}&apos; using Workaround from page &apos;{1}&apos;.
        /// </summary>
        internal static string Info_RetreivingExportWebPartXmlWorkaround {
            get {
                return ResourceManager.GetString("Info_RetreivingExportWebPartXmlWorkaround", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transformation of page &apos;{0}&apos; of type &apos;{1}&apos;.
        /// </summary>
        internal static string Info_TransformationMode {
            get {
                return ResourceManager.GetString("Info_TransformationMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting title of page &apos;{0}&apos; to value: &apos;{1}&apos;.
        /// </summary>
        internal static string Info_TransformPageModernTitle {
            get {
                return ResourceManager.GetString("Info_TransformPageModernTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing empty text web part.
        /// </summary>
        internal static string Info_TransformRemovingEmptyWebPart {
            get {
                return ResourceManager.GetString("Info_TransformRemovingEmptyWebPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current page is used as a home page - settings modern page to &apos;Home&apos; layout.
        /// </summary>
        internal static string Info_TransformSourcePageIsHomePage {
            get {
                return ResourceManager.GetString("Info_TransformSourcePageIsHomePage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current page is not used as the site home page.
        /// </summary>
        internal static string Info_TransformSourcePageIsNotHomePage {
            get {
                return ResourceManager.GetString("Info_TransformSourcePageIsNotHomePage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default remapping mechanism for user: {0}.
        /// </summary>
        internal static string Info_UserTransformDefaultMapping {
            get {
                return ResourceManager.GetString("Info_UserTransformDefaultMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping for user cannot be found: {0}.
        /// </summary>
        internal static string Info_UserTransformMappingNotFound {
            get {
                return ResourceManager.GetString("Info_UserTransformMappingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping done and user replaced: from {0} to {1}.
        /// </summary>
        internal static string Info_UserTransformSuccess {
            get {
                return ResourceManager.GetString("Info_UserTransformSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using &apos;custom&apos; modern web part.
        /// </summary>
        internal static string Info_UsingCustomModernWebPart {
            get {
                return ResourceManager.GetString("Info_UsingCustomModernWebPart", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome page setting does exist, checking if the transform page is a home page.
        /// </summary>
        internal static string Info_WelcomePageSettingsIsPresent {
            get {
                return ResourceManager.GetString("Info_WelcomePageSettingsIsPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Xml Mapping saved as {0}.
        /// </summary>
        internal static string Info_XmlMappingSavedAs {
            get {
                return ResourceManager.GetString("Info_XmlMappingSavedAs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not retrieve field value from mapping, the contents were empty.
        /// </summary>
        internal static string Warning_CannotRetrieveFieldValue {
            get {
                return ResourceManager.GetString("Warning_CannotRetrieveFieldValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Web Part Mapping not found.
        /// </summary>
        internal static string Warning_ContentWebPartMappingNotFound {
            get {
                return ResourceManager.GetString("Warning_ContentWebPartMappingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping this web part&apos;s transformation - cross site not supported.
        /// </summary>
        internal static string Warning_CrossSiteNotSupported {
            get {
                return ResourceManager.GetString("Warning_CrossSiteNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CSOM request frequency exceeded usage limits. Retry attempt {0}. Sleeping for {1} milliseconds before retrying..
        /// </summary>
        internal static string Warning_CSOMRequestFrequencyExceeded {
            get {
                return ResourceManager.GetString("Warning_CSOMRequestFrequencyExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CSOM request timeout. Retry attempt {0}. Sleeping for {1} milliseconds before retrying..
        /// </summary>
        internal static string Warning_CSOMRequestTimeout {
            get {
                return ResourceManager.GetString("Warning_CSOMRequestTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is nothing to transform - no web parts found.
        /// </summary>
        internal static string Warning_NothingToTransform {
            get {
                return ResourceManager.GetString("Warning_NothingToTransform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page layout could not be determined by the publishing page.
        /// </summary>
        internal static string Warning_PageLayoutsCannotBeDetermined {
            get {
                return ResourceManager.GetString("Warning_PageLayoutsCannotBeDetermined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target web part {0} is not added for field {1} because the field value was empty and the RemoveEmptySectionsAndColumns flag was set.
        /// </summary>
        internal static string Warning_SkippedWebPartDueToEmptyInSourcee {
            get {
                return ResourceManager.GetString("Warning_SkippedWebPartDueToEmptyInSourcee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Table could not be normalized and will be taken over as is.
        /// </summary>
        internal static string Warning_TableCouldNotBeNormalized {
            get {
                return ResourceManager.GetString("Warning_TableCouldNotBeNormalized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You don&apos;t have needed the needed permission level (ManagePermissions) to read item level permissions.
        /// </summary>
        internal static string Warning_TransformGetItemPermissionsAccessDenied {
            get {
                return ResourceManager.GetString("Warning_TransformGetItemPermissionsAccessDenied", resourceCulture);
            }
        }
    }
}
