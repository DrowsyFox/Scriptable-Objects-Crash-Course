// Attributes stub generated for Odin Inspector version 3.0.9.0

#if !ODIN_INSPECTOR && !DF_PROCESSING
namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class AssetListAttribute : Attribute{public bool AutoPopulate;public string Tags;public string LayerNames;public string AssetNamePrefix;public string Path;public string CustomFilterMethod;public AssetListAttribute(){this.AutoPopulate
 = false;this.Tags = null;this.LayerNames = null;this.AssetNamePrefix = null;this.CustomFilterMethod =
 null;}}}namespace Sirenix.OdinInspector{using System;using System.Linq;[System.Diagnostics.Conditional("UNITY_EDITOR")]public class AssetSelectorAttribute : Attribute{public bool IsUniqueList
 = true;public bool DrawDropdownForListElements =
 true;public bool DisableListAddButtonBehaviour;public bool ExcludeExistingValuesInList;public bool ExpandAllMenuItems =
 true;public bool FlattenTreeView;public int DropdownWidth;public int DropdownHeight;public string DropdownTitle;public string[] SearchInFolders;public string Filter;public string Paths{set{this.SearchInFolders
 =
 value.Split('|').Select(x => x.Trim().Trim('/', '\\')).ToArray();}get { return this.SearchInFolders == null ? null : string.Join(",", this.SearchInFolders); }}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class AssetsOnlyAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class BoxGroupAttribute : PropertyGroupAttribute{public bool ShowLabel;public bool CenterLabel;public string LabelText;public BoxGroupAttribute(string group, bool showLabel
 = true, bool centerLabel = false, float order = 0): base(group, order){this.ShowLabel = showLabel;this.CenterLabel =
 centerLabel;}public BoxGroupAttribute(): this("_DefaultBoxGroup", false){}protected override void CombineValuesWith(PropertyGroupAttribute other){var attr
 = other as BoxGroupAttribute;if (this.ShowLabel == false || attr.ShowLabel == false){this.ShowLabel =
 false;attr.ShowLabel = false;}this.CenterLabel |=
 attr.CenterLabel;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ButtonAttribute : ShowInInspectorAttribute{public int ButtonHeight;public string Name;public ButtonStyle Style;public bool Expanded;public bool DisplayParameters
 = true;public bool DirtyOnClick = true;public bool DrawResult{set{this.drawResult = value;this.drawResultIsSet =
 true;}get { return this.drawResult; }}public bool DrawResultIsSet{get { return this.drawResultIsSet; }}private bool drawResult;private bool drawResultIsSet;public ButtonAttribute(){this.Name
 = null;this.ButtonHeight = (int)ButtonSizes.Small;}public ButtonAttribute(ButtonSizes size){this.Name =
 null;this.ButtonHeight = (int)size;}public ButtonAttribute(int buttonSize){this.ButtonHeight = buttonSize;this.Name =
 null;}public ButtonAttribute(string name){this.Name = name;this.ButtonHeight =
 (int)ButtonSizes.Small;}public ButtonAttribute(string name, ButtonSizes buttonSize){this.Name = name;this.ButtonHeight
 = (int)buttonSize;}public ButtonAttribute(string name, int buttonSize){this.Name = name;this.ButtonHeight =
 buttonSize;}public ButtonAttribute(ButtonStyle parameterBtnStyle){this.Name = null;this.ButtonHeight =
 (int)ButtonSizes.Small;this.Style =
 parameterBtnStyle;}public ButtonAttribute(int buttonSize, ButtonStyle parameterBtnStyle){this.ButtonHeight =
 buttonSize;this.Name = null;this.Style =
 parameterBtnStyle;}public ButtonAttribute(ButtonSizes size, ButtonStyle parameterBtnStyle){this.ButtonHeight =
 (int)size;this.Name = null;this.Style =
 parameterBtnStyle;}public ButtonAttribute(string name, ButtonStyle parameterBtnStyle){this.Name =
 name;this.ButtonHeight = (int)ButtonSizes.Small;this.Style =
 parameterBtnStyle;}public ButtonAttribute(string name, ButtonSizes buttonSize, ButtonStyle parameterBtnStyle){this.Name
 = name;this.ButtonHeight = (int)buttonSize;this.Style =
 parameterBtnStyle;}public ButtonAttribute(string name, int buttonSize, ButtonStyle parameterBtnStyle){this.Name =
 name;this.ButtonHeight = buttonSize;this.Style =
 parameterBtnStyle;}}}namespace Sirenix.OdinInspector{using System;[IncludeMyAttributes, ShowInInspector][AttributeUsage(AttributeTargets.Method, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ButtonGroupAttribute : PropertyGroupAttribute{public ButtonGroupAttribute(string group
 = "_DefaultGroup", float order =
 0): base(group, order){ }}}namespace Sirenix.OdinInspector{public enum ButtonStyle{CompactBox,FoldoutButton,Box,}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public class ChildGameObjectsOnlyAttribute : Attribute{public bool IncludeSelf
 = true;public bool IncludeInactive =
 false;}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ColorPaletteAttribute : Attribute{public string PaletteName;public bool ShowAlpha;public ColorPaletteAttribute(){this.PaletteName
 = null;this.ShowAlpha = true;}public ColorPaletteAttribute(string paletteName){this.PaletteName =
 paletteName;this.ShowAlpha =
 true;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class CustomContextMenuAttribute : Attribute{public string MenuItem;[Obsolete("Use the Action member instead.",false)]public string MethodName { get { return this.Action; } set { this.Action
 = value; } }public string Action;public CustomContextMenuAttribute(string menuItem, string action){this.MenuItem =
 menuItem;this.Action =
 action;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class CustomValueDrawerAttribute : Attribute{[Obsolete("Use the Action member instead.",false)]public string MethodName { get { return this.Action; } set { this.Action
 = value; } }public string Action;public CustomValueDrawerAttribute(string action){this.Action =
 action;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DelayedPropertyAttribute : Attribute{ }}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][DontApplyToListElements][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DetailedInfoBoxAttribute : Attribute{public string Message;public string Details;public InfoMessageType InfoMessageType;public string VisibleIf;public DetailedInfoBoxAttribute(string message, string details, InfoMessageType infoMessageType
 = InfoMessageType.Info, string visibleIf = null){this.Message = message;this.Details = details;this.InfoMessageType =
 infoMessageType;this.VisibleIf =
 visibleIf;}}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class DictionaryDrawerSettings : Attribute{public string KeyLabel
 = "Key";public string ValueLabel =
 "Value";public DictionaryDisplayOptions DisplayMode;public bool IsReadOnly;public float KeyColumnWidth =
 130f;}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class DisableContextMenuAttribute : Attribute{public bool DisableForMember;public bool DisableForCollectionElements;public DisableContextMenuAttribute(bool disableForMember
 = true, bool disableCollectionElements = false){this.DisableForMember =
 disableForMember;this.DisableForCollectionElements =
 disableCollectionElements;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class DisableIfAttribute : Attribute{[Obsolete("Use the Condition member instead.",false)]public string MemberName { get { return this.Condition; } set { this.Condition
 = value; } }public string Condition;public object Value;public DisableIfAttribute(string condition){this.Condition =
 condition;}public DisableIfAttribute(string condition, object optionalValue){this.Condition = condition;this.Value =
 optionalValue;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DisableInEditorModeAttribute : Attribute{ }}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DisableInInlineEditorsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DisableInNonPrefabsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All)][DontApplyToListElements][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DisableInPlayModeAttribute : Attribute{ }}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DisableInPrefabAssetsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DisableInPrefabInstancesAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DisableInPrefabsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class DisplayAsStringAttribute : Attribute{public bool Overflow;public DisplayAsStringAttribute(){this.Overflow
 = true;}public DisplayAsStringAttribute(bool overflow){this.Overflow =
 overflow;}}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class DoNotDrawAsReferenceAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.Class)]public sealed class DontApplyToListElementsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DontValidateAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class DrawWithUnityAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[Obsolete("Use DisableInPrefabInstance or DisableInPrefabAsset instead.", false)][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class EnableForPrefabOnlyAttribute : Attribute{ }}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class EnableGUIAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class EnableIfAttribute : Attribute{[Obsolete("Use the Condition member instead.",false)]public string MemberName { get { return this.Condition; } set { this.Condition
 = value; } }public string Condition;public object Value;public EnableIfAttribute(string condition){this.Condition =
 condition;}public EnableIfAttribute(string condition, object optionalValue){this.Condition = condition;this.Value =
 optionalValue;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class EnumPagingAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public class EnumToggleButtonsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class FilePathAttribute : Attribute{public bool AbsolutePath;public string Extensions;public string ParentFolder;[Obsolete("Use RequireExistingPath instead.", true)]public bool RequireValidPath;public bool RequireExistingPath;public bool UseBackslashes;[Obsolete("Add a ReadOnly attribute to the property instead.", true)]public bool ReadOnly { get; set; }}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class FolderPathAttribute : Attribute{public bool AbsolutePath;public string ParentFolder;[Obsolete("Use RequireExistingPath instead.", true)]public bool RequireValidPath;public bool RequireExistingPath;public bool UseBackslashes;}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class FoldoutGroupAttribute : PropertyGroupAttribute{private bool expanded;public bool Expanded{get { return this.expanded; }set{this.expanded
 = value;this.HasDefinedExpanded =
 true;}}public bool HasDefinedExpanded { get; private set; }public FoldoutGroupAttribute(string groupName, float order =
 0): base(groupName, order){}public FoldoutGroupAttribute(string groupName, bool expanded, float order =
 0): base(groupName, order){this.expanded = expanded;this.HasDefinedExpanded =
 true;}protected override void CombineValuesWith(PropertyGroupAttribute other){var attr =
 other as FoldoutGroupAttribute;if (attr.HasDefinedExpanded){this.HasDefinedExpanded = true;this.Expanded =
 attr.Expanded;}if (this.HasDefinedExpanded){attr.HasDefinedExpanded = true;attr.Expanded =
 this.Expanded;}}}}namespace Sirenix.OdinInspector{using System;using UnityEngine;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class GUIColorAttribute : Attribute{public Color Color;public string GetColor;public GUIColorAttribute(float r, float g, float b, float a
 = 1f){this.Color = new Color(r, g, b, a);}public GUIColorAttribute(string getColor){this.GetColor =
 getColor;}}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideDuplicateReferenceBoxAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][DontApplyToListElements][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class HideIfAttribute : Attribute{[Obsolete("Use the Condition member instead.",false)]public string MemberName { get { return this.Condition; } set { this.Condition
 =
 value; } }public string Condition;public object Value;public bool Animate;public HideIfAttribute(string condition, bool animate
 = true){this.Condition = condition;this.Animate =
 animate;}public HideIfAttribute(string condition, object optionalValue, bool animate = true){this.Condition =
 condition;this.Value = optionalValue;this.Animate =
 animate;}}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideIfGroupAttribute : PropertyGroupAttribute{public bool Animate { get { return base.AnimateVisibility; } set { base.AnimateVisibility
 =
 value; } }public object Value;[Obsolete("Use the Condition member instead.",false)]public string MemberName { get { return this.Condition; } set { this.Condition
 =
 value; } }public string Condition{get{return string.IsNullOrEmpty(base.VisibleIf)? this.GroupName: base.VisibleIf;}set { base.VisibleIf
 = value; }}public HideIfGroupAttribute(string path, bool animate = true) : base(path){this.Animate =
 animate;}public HideIfGroupAttribute(string path, object value, bool animate = true) : base(path){this.Value =
 value;this.Animate = animate;}protected override void CombineValuesWith(PropertyGroupAttribute other){var attr =
 other as HideIfGroupAttribute;if (this.Value != null){attr.Value =
 this.Value;}}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInEditorModeAttribute : Attribute{ }}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInInlineEditorsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInNonPrefabsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All)][DontApplyToListElements][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInPlayModeAttribute : Attribute{ }}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInPrefabAssetsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInPrefabInstancesAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInPrefabsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideInTablesAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargetFlags.Default)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideLabelAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.Class, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class HideMonoScriptAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.Class, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class HideNetworkBehaviourFieldsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HideReferenceObjectPickerAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class HorizontalGroupAttribute : PropertyGroupAttribute{public float Width;public float MarginLeft;public float MarginRight;public float PaddingLeft;public float PaddingRight;public float MinWidth;public float MaxWidth;public string Title;public float LabelWidth;public HorizontalGroupAttribute(string group, float width
 = 0, int marginLeft = 0, int marginRight = 0, float order = 0): base(group, order){this.Width = width;this.MarginLeft =
 marginLeft;this.MarginRight = marginRight;}public HorizontalGroupAttribute(float width = 0, int marginLeft =
 0, int marginRight = 0, float order =
 0): this("_DefaultHorizontalGroup", width, marginLeft, marginRight, order){}protected override void CombineValuesWith(PropertyGroupAttribute other){this.Title
 = this.Title ?? (other as HorizontalGroupAttribute).Title;this.LabelWidth =
 Math.Max(this.LabelWidth, (other as HorizontalGroupAttribute).LabelWidth);}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class IndentAttribute : Attribute{public int IndentLevel;public IndentAttribute(int indentLevel
 = 1){this.IndentLevel =
 indentLevel;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class InfoBoxAttribute : Attribute{public string Message;public InfoMessageType InfoMessageType;public string VisibleIf;public bool GUIAlwaysEnabled;public InfoBoxAttribute(string message, InfoMessageType infoMessageType
 = InfoMessageType.Info, string visibleIfMemberName = null){this.Message = message;this.InfoMessageType =
 infoMessageType;this.VisibleIf =
 visibleIfMemberName;}public InfoBoxAttribute(string message, string visibleIfMemberName){this.Message =
 message;this.InfoMessageType = InfoMessageType.Info;this.VisibleIf =
 visibleIfMemberName;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class InlineButtonAttribute : Attribute{[Obsolete("Use the Action member instead.",false)]public string MemberMethod { get { return this.Action; } set { this.Action
 =
 value; } }public string Action;public string Label;public string ShowIf;public InlineButtonAttribute(string action, string label
 = null){this.Action = action;this.Label =
 label;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class InlineEditorAttribute : Attribute{private bool expanded;public bool Expanded{get { return this.expanded; }set{this.expanded
 = value;this.ExpandedHasValue =
 true;}}public bool DrawHeader;public bool DrawGUI;public bool DrawPreview;public float MaxHeight;public float PreviewWidth
 = 100;public float PreviewHeight = 35;public bool IncrementInlineEditorDrawerDepth =
 true;public InlineEditorObjectFieldModes ObjectFieldMode;public bool DisableGUIForVCSLockedAssets =
 true;public bool ExpandedHasValue { get; private set; }public InlineEditorAttribute(InlineEditorModes inlineEditorMode
 = InlineEditorModes.GUIOnly, InlineEditorObjectFieldModes objectFieldMode =
 InlineEditorObjectFieldModes.Boxed){this.ObjectFieldMode =
 objectFieldMode;switch (inlineEditorMode){case InlineEditorModes.GUIOnly:this.DrawGUI =
 true;break;case InlineEditorModes.GUIAndHeader:this.DrawGUI = true;this.DrawHeader =
 true;break;case InlineEditorModes.GUIAndPreview:this.DrawGUI = true;this.DrawPreview =
 true;break;case InlineEditorModes.SmallPreview:this.expanded = true;this.DrawPreview =
 true;break;case InlineEditorModes.LargePreview:this.expanded = true;this.DrawPreview = true;this.PreviewHeight =
 170;break;case InlineEditorModes.FullEditor:this.DrawGUI = true;this.DrawHeader = true;this.DrawPreview =
 true;break;default:throw new NotImplementedException();}}public InlineEditorAttribute(InlineEditorObjectFieldModes objectFieldMode): this(InlineEditorModes.GUIOnly, objectFieldMode){}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, Inherited
 =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class InlinePropertyAttribute : Attribute{public int LabelWidth;}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class LabelTextAttribute : Attribute{public string Text;public bool NicifyText;public LabelTextAttribute(string text){this.Text
 = text;}public LabelTextAttribute(string text, bool nicifyText){this.Text = text;this.NicifyText =
 nicifyText;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class LabelWidthAttribute : Attribute{public float Width;public LabelWidthAttribute(float width){this.Width
 = width;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")][DontApplyToListElements]public sealed class ListDrawerSettingsAttribute : Attribute{public bool HideAddButton;public bool HideRemoveButton;public string ListElementLabelName;public string CustomAddFunction;public string CustomRemoveIndexFunction;public string CustomRemoveElementFunction;public string OnBeginListElementGUI;public string OnEndListElementGUI;public bool AlwaysAddDefaultValue;public bool AddCopiesLastElement
 = false;public string ElementColor;private string onTitleBarGUI =
 null;private int numberOfItemsPerPage;private bool paging;private bool draggable;private bool isReadOnly;private bool showItemCount;private bool pagingHasValue
 = false;private bool draggableHasValue = false;private bool isReadOnlyHasValue =
 false;private bool showItemCountHasValue = false;private bool expanded = false;private bool expandedHasValue =
 false;private bool numberOfItemsPerPageHasValue = false;private bool showIndexLabels =
 false;private bool showIndexLabelsHasValue = false;public bool ShowPaging{get{return this.paging;}set{this.paging =
 value;this.pagingHasValue = true;}}public bool DraggableItems{get { return this.draggable; }set{this.draggable =
 value;this.draggableHasValue =
 true;}}public int NumberOfItemsPerPage{get { return this.numberOfItemsPerPage; }set{this.numberOfItemsPerPage =
 value;this.numberOfItemsPerPageHasValue =
 true;}}public bool IsReadOnly{get { return this.isReadOnly; }set{this.isReadOnly = value;this.isReadOnlyHasValue =
 true;}}public bool ShowItemCount{get { return this.showItemCount; }set{this.showItemCount =
 value;this.showItemCountHasValue = true;}}public bool Expanded{get { return this.expanded; }set{this.expanded =
 value;this.expandedHasValue =
 true;}}public bool ShowIndexLabels{get { return this.showIndexLabels; }set{this.showIndexLabels =
 value;this.showIndexLabelsHasValue =
 true;}}public string OnTitleBarGUI{get { return this.onTitleBarGUI; }set { this.onTitleBarGUI =
 value; }}public bool PagingHasValue { get { return this.pagingHasValue; } }public bool ShowItemCountHasValue { get { return this.showItemCountHasValue; } }public bool NumberOfItemsPerPageHasValue { get { return this.numberOfItemsPerPageHasValue; } }public bool DraggableHasValue { get { return this.draggableHasValue; } }public bool IsReadOnlyHasValue { get { return this.isReadOnlyHasValue; } }public bool ExpandedHasValue { get { return this.expandedHasValue; } }public bool ShowIndexLabelsHasValue { get { return this.showIndexLabelsHasValue; } }}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class MaxValueAttribute : Attribute{public double MaxValue;public string Expression;public MaxValueAttribute(double maxValue){this.MaxValue
 = maxValue;}public MaxValueAttribute(string expression){this.Expression =
 expression;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class MinMaxSliderAttribute : Attribute{public float MinValue;public float MaxValue;[Obsolete("Use the MinValueGetter member instead.",false)]public string MinMember { get { return this.MinValueGetter; } set { this.MinValueGetter
 =
 value; } }public string MinValueGetter;[Obsolete("Use the MaxValueGetter member instead.",false)]public string MaxMember { get { return this.MaxValueGetter; } set { this.MaxValueGetter
 =
 value; } }public string MaxValueGetter;[Obsolete("Use the MinMaxValueGetter member instead.",false)]public string MinMaxMember { get { return this.MinMaxValueGetter; } set { this.MinMaxValueGetter
 =
 value; } }public string MinMaxValueGetter;public bool ShowFields;public MinMaxSliderAttribute(float minValue, float maxValue, bool showFields
 = false){this.MinValue = minValue;this.MaxValue = maxValue;this.ShowFields =
 showFields;}public MinMaxSliderAttribute(string minValueGetter, float maxValue, bool showFields =
 false){this.MinValueGetter = minValueGetter;this.MaxValue = maxValue;this.ShowFields =
 showFields;}public MinMaxSliderAttribute(float minValue, string maxValueGetter, bool showFields = false){this.MinValue
 = minValue;this.MaxValueGetter = maxValueGetter;this.ShowFields =
 showFields;}public MinMaxSliderAttribute(string minValueGetter, string maxValueGetter, bool showFields =
 false){this.MinValueGetter = minValueGetter;this.MaxValueGetter = maxValueGetter;this.ShowFields =
 showFields;}public MinMaxSliderAttribute(string minMaxValueGetter, bool showFields = false){this.MinMaxValueGetter =
 minMaxValueGetter;this.ShowFields =
 showFields;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class MinValueAttribute : Attribute{public double MinValue;public string Expression;public MinValueAttribute(double minValue){this.MinValue
 = minValue;}public MinValueAttribute(string expression){this.Expression =
 expression;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class MultiLinePropertyAttribute : Attribute{public int Lines;public MultiLinePropertyAttribute(int lines
 = 3){this.Lines =
 Math.Max(1, lines);}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class OnCollectionChangedAttribute : Attribute{public string Before;public string After;public OnCollectionChangedAttribute() { }public OnCollectionChangedAttribute(string after){this.After
 = after;}public OnCollectionChangedAttribute(string before, string after){this.Before = before;this.After =
 after;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 true, Inherited =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")][DontApplyToListElements][IncludeMyAttributes, HideInTables]public class OnInspectorDisposeAttribute : ShowInInspectorAttribute{public string Action;public OnInspectorDisposeAttribute(){}public OnInspectorDisposeAttribute(string action){this.Action
 =
 action;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class OnInspectorGUIAttribute : ShowInInspectorAttribute{public string Prepend;public string Append;[Obsolete("Use the Prepend member instead.",false)]public string PrependMethodName;[Obsolete("Use the Append member instead.",false)]public string AppendMethodName;public OnInspectorGUIAttribute(){}public OnInspectorGUIAttribute(string action, bool append
 = true){if (append){this.Append = action;}else{this.Prepend =
 action;}}public OnInspectorGUIAttribute(string prepend, string append){this.Prepend = prepend;this.Append =
 append;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 true, Inherited =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")][DontApplyToListElements][IncludeMyAttributes, HideInTables]public class OnInspectorInitAttribute : ShowInInspectorAttribute{public string Action;public OnInspectorInitAttribute(){}public OnInspectorInitAttribute(string action){this.Action
 =
 action;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")][IncludeMyAttributes, HideInTables]public sealed class OnStateUpdateAttribute : Attribute{public string Action;public OnStateUpdateAttribute(string action){this.Action
 =
 action;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class OnValueChangedAttribute : Attribute{[Obsolete("Use the Action member instead.",false)]public string MethodName { get { return this.Action; } set { this.Action
 = value; } }public string Action;public bool IncludeChildren;public bool InvokeOnUndoRedo =
 true;public bool InvokeOnInitialize = false;public OnValueChangedAttribute(string action, bool includeChildren =
 false){this.Action = action;this.IncludeChildren =
 includeChildren;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class PreviewFieldAttribute : Attribute{private ObjectFieldAlignment alignment;private bool alignmentHasValue;public float Height;public ObjectFieldAlignment Alignment{get { return this.alignment; }set{this.alignment
 = value;this.alignmentHasValue =
 true;}}public bool AlignmentHasValue { get { return this.alignmentHasValue; } }public PreviewFieldAttribute(){this.Height
 = 0;}public PreviewFieldAttribute(float height){this.Height =
 height;}public PreviewFieldAttribute(float height, ObjectFieldAlignment alignment){this.Height = height;this.Alignment
 = alignment;}public PreviewFieldAttribute(ObjectFieldAlignment alignment){this.Alignment =
 alignment;}}}namespace Sirenix.OdinInspector{using System;using UnityEngine;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ProgressBarAttribute : Attribute{public double Min;public double Max;[Obsolete("Use the MinGetter member instead.",false)]public string MinMember { get { return this.MinGetter; } set { this.MinGetter
 =
 value; } }public string MinGetter;[Obsolete("Use the MaxGetter member instead.",false)]public string MaxMember { get { return this.MaxGetter; } set { this.MaxGetter
 =
 value; } }public string MaxGetter;public float R;public float G;public float B;public int Height;[Obsolete("Use the ColorGetter member instead.",false)]public string ColorMember { get { return this.ColorGetter; } set { this.ColorGetter
 =
 value; } }public string ColorGetter;[Obsolete("Use the BackgroundColorGetter member instead.",false)]public string BackgroundColorMember { get { return this.BackgroundColorGetter; } set { this.BackgroundColorGetter
 =
 value; } }public string BackgroundColorGetter;public bool Segmented;[Obsolete("Use the CustomValueStringGetter member instead.",false)]public string CustomValueStringMember { get { return this.CustomValueStringGetter; } set { this.CustomValueStringGetter
 =
 value; } }public string CustomValueStringGetter;private bool drawValueLabel;private TextAlignment valueLabelAlignment;public ProgressBarAttribute(double min, double max, float r
 = 0.15f, float g = 0.47f, float b = 0.74f){this.Min = min;this.Max = max;this.R = r;this.G = g;this.B = b;this.Height =
 12;this.Segmented = false;this.drawValueLabel = true;this.DrawValueLabelHasValue = false;this.valueLabelAlignment =
 TextAlignment.Center;this.ValueLabelAlignmentHasValue =
 false;}public ProgressBarAttribute(string minGetter, double max, float r = 0.15f, float g = 0.47f, float b =
 0.74f){this.MinGetter = minGetter;this.Max = max;this.R = r;this.G = g;this.B = b;this.Height = 12;this.Segmented =
 false;this.drawValueLabel = true;this.DrawValueLabelHasValue = false;this.valueLabelAlignment =
 TextAlignment.Center;this.ValueLabelAlignmentHasValue =
 false;}public ProgressBarAttribute(double min, string maxGetter, float r = 0.15f, float g = 0.47f, float b =
 0.74f){this.Min = min;this.MaxGetter = maxGetter;this.R = r;this.G = g;this.B = b;this.Height = 12;this.Segmented =
 false;this.drawValueLabel = true;this.DrawValueLabelHasValue = false;this.valueLabelAlignment =
 TextAlignment.Center;this.ValueLabelAlignmentHasValue =
 false;}public ProgressBarAttribute(string minGetter, string maxGetter, float r = 0.15f, float g = 0.47f, float b =
 0.74f){this.MinGetter = minGetter;this.MaxGetter = maxGetter;this.R = r;this.G = g;this.B = b;this.Height =
 12;this.Segmented = false;this.drawValueLabel = true;this.DrawValueLabelHasValue = false;this.valueLabelAlignment =
 TextAlignment.Center;this.ValueLabelAlignmentHasValue =
 false;}public bool DrawValueLabel{get{return this.drawValueLabel;}set{this.drawValueLabel =
 value;this.DrawValueLabelHasValue =
 true;}}public bool DrawValueLabelHasValue { get; private set; }public TextAlignment ValueLabelAlignment{get{return this.valueLabelAlignment;}set{this.valueLabelAlignment
 = value;this.ValueLabelAlignmentHasValue =
 true;}}public bool ValueLabelAlignmentHasValue { get; private set; }public Color Color { get { return new Color(this.R, this.G, this.B, 1f);  } }}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public abstract class PropertyGroupAttribute : Attribute{public string GroupID;public string GroupName;public float Order;public bool HideWhenChildrenAreInvisible
 = true;public string VisibleIf;public bool AnimateVisibility =
 true;public PropertyGroupAttribute(string groupId, float order){this.GroupID = groupId;this.Order = order;var index =
 groupId.LastIndexOf('/');this.GroupName =
 index >= 0 && index < groupId.Length ? groupId.Substring(index + 1) : groupId;}public PropertyGroupAttribute(string groupId): this(groupId, 0){}public PropertyGroupAttribute Combine(PropertyGroupAttribute other){if (other == null){throw new ArgumentNullException("other");}if (other.GetType() != this.GetType()){throw new ArgumentException("Attributes to combine are not of the same type.");}if (other.GroupID != this.GroupID){throw new ArgumentException("PropertyGroupAttributes to combine must have the same group id.");}if (this.Order == 0){this.Order
 = other.Order;}else if (other.Order != 0){this.Order =
 Math.Min(this.Order, other.Order);}this.HideWhenChildrenAreInvisible &=
 other.HideWhenChildrenAreInvisible;if (this.VisibleIf == null){this.VisibleIf = other.VisibleIf;}this.AnimateVisibility
 &=
 other.AnimateVisibility;this.CombineValuesWith(other);return this;}protected virtual void CombineValuesWith(PropertyGroupAttribute other){}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class PropertyOrderAttribute : Attribute{public float Order;public PropertyOrderAttribute(){}public PropertyOrderAttribute(float order){this.Order
 = order;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class PropertyRangeAttribute : Attribute{public double Min;public double Max;[Obsolete("Use the MinGetter member instead.",false)]public string MinMember { get { return this.MinGetter; } set { this.MinGetter
 =
 value; } }public string MinGetter;[Obsolete("Use the MaxGetter member instead.",false)]public string MaxMember { get { return this.MaxGetter; } set { this.MaxGetter
 = value; } }public string MaxGetter;public PropertyRangeAttribute(double min, double max){this.Min =
 min < max ? min : max;this.Max =
 max > min ? max : min;}public PropertyRangeAttribute(string minGetter, double max){this.MinGetter = minGetter;this.Max
 = max;}public PropertyRangeAttribute(double min, string maxGetter){this.Min = min;this.MaxGetter =
 maxGetter;}public PropertyRangeAttribute(string minGetter, string maxGetter){this.MinGetter = minGetter;this.MaxGetter
 = maxGetter;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true), DontApplyToListElements][System.Diagnostics.Conditional("UNITY_EDITOR")]public class PropertySpaceAttribute : Attribute{public float SpaceBefore;public float SpaceAfter;public PropertySpaceAttribute(){this.SpaceBefore
 = 8f;this.SpaceAfter = 0f;}public PropertySpaceAttribute(float spaceBefore){this.SpaceBefore =
 spaceBefore;this.SpaceAfter = 0f;}public PropertySpaceAttribute(float spaceBefore, float spaceAfter){this.SpaceBefore =
 spaceBefore;this.SpaceAfter =
 spaceAfter;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class PropertyTooltipAttribute : Attribute{public string Tooltip;public PropertyTooltipAttribute(string tooltip){this.Tooltip
 = tooltip;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ReadOnlyAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class RequiredAttribute : Attribute{public string ErrorMessage;public InfoMessageType MessageType;public RequiredAttribute(){this.MessageType
 = InfoMessageType.Error;}public RequiredAttribute(string errorMessage, InfoMessageType messageType){this.ErrorMessage =
 errorMessage;this.MessageType = messageType;}public RequiredAttribute(string errorMessage){this.ErrorMessage =
 errorMessage;this.MessageType =
 InfoMessageType.Error;}public RequiredAttribute(InfoMessageType messageType){this.MessageType =
 messageType;}}}namespace Sirenix.OdinInspector{using System;[IncludeMyAttributes, ShowInInspector][AttributeUsage(AttributeTargets.Method, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute{public ButtonSizes DefaultButtonSize
 = ButtonSizes.Medium;public bool UniformLayout = false;public ResponsiveButtonGroupAttribute(string group =
 "_DefaultResponsiveButtonGroup"): base(group){}protected override void CombineValuesWith(PropertyGroupAttribute other){var otherAttr
 =
 other as ResponsiveButtonGroupAttribute;if (other == null){return;}if (otherAttr.DefaultButtonSize != ButtonSizes.Medium){this.DefaultButtonSize
 = otherAttr.DefaultButtonSize;}else if (this.DefaultButtonSize != ButtonSizes.Medium){otherAttr.DefaultButtonSize =
 this.DefaultButtonSize;}this.UniformLayout =
 this.UniformLayout || otherAttr.UniformLayout;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class SceneObjectsOnlyAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")][DontApplyToListElements]public class SearchableAttribute : Attribute{public bool FuzzySearch
 = true;public SearchFilterOptions FilterOptions = SearchFilterOptions.All;public bool Recursive =
 true;}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ShowDrawerChainAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[Obsolete("Use HideInPrefabInstance or HideInPrefabAsset instead.", false)][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ShowForPrefabOnlyAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ShowIfAttribute : Attribute{[Obsolete("Use the Condition member instead.",false)]public string MemberName { get { return this.Condition; } set { this.Condition
 =
 value; } }public string Condition;public object Value;public bool Animate;public ShowIfAttribute(string condition, bool animate
 = true){this.Condition = condition;this.Animate =
 animate;}public ShowIfAttribute(string condition, object optionalValue, bool animate = true){this.Condition =
 condition;this.Value = optionalValue;this.Animate =
 animate;}}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public class ShowIfGroupAttribute : PropertyGroupAttribute{public bool Animate { get { return base.AnimateVisibility; } set { base.AnimateVisibility
 =
 value; } }public object Value;[Obsolete("Use the Condition member instead.",false)]public string MemberName { get { return this.Condition; } set { this.Condition
 =
 value; } }public string Condition{get{return string.IsNullOrEmpty(base.VisibleIf)? this.GroupName: base.VisibleIf;}set { base.VisibleIf
 = value; }}public ShowIfGroupAttribute(string path, bool animate = true) : base(path){this.Animate =
 animate;}public ShowIfGroupAttribute(string path, object value, bool animate = true) : base(path){this.Value =
 value;this.Animate = animate;}protected override void CombineValuesWith(PropertyGroupAttribute other){var attr =
 other as ShowIfGroupAttribute;if (this.Value != null){attr.Value =
 this.Value;}}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ShowInInlineEditorsAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[JetBrains.Annotations.MeansImplicitUse][AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ShowInInspectorAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.Class, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ShowOdinSerializedPropertiesInInspectorAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[System.Diagnostics.Conditional("UNITY_EDITOR")]public class ShowPropertyResolverAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class SuffixLabelAttribute : Attribute{public string Label;public bool Overlay;public SuffixLabelAttribute(string label, bool overlay
 = false){this.Label = label;this.Overlay =
 overlay;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class SuppressInvalidAttributeErrorAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;using System.Collections.Generic;using Sirenix.OdinInspector.Internal;[System.Diagnostics.Conditional("UNITY_EDITOR")][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)]public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute{public const string DEFAULT_NAME
 =
 "_DefaultTabGroup";public string TabName;public bool UseFixedHeight;public bool Paddingless;public bool HideTabGroupIfTabGroupOnlyHasOneTab;public TabGroupAttribute(string tab, bool useFixedHeight
 = false, float order =
 0): this(DEFAULT_NAME, tab, useFixedHeight, order){ }public TabGroupAttribute(string group, string tab, bool useFixedHeight
 = false, float order = 0): base(group, order){this.TabName = tab;this.UseFixedHeight = useFixedHeight;this.Tabs =
 new List<string>();if (tab != null){this.Tabs.Add(tab);}this.Tabs =
 new List<string>(this.Tabs);}public List<string> Tabs { get; private set; }protected override void CombineValuesWith(PropertyGroupAttribute other){base.CombineValuesWith(other);var otherTab
 = other as TabGroupAttribute;if (otherTab.TabName != null){this.UseFixedHeight =
 this.UseFixedHeight || otherTab.UseFixedHeight;this.Paddingless =
 this.Paddingless || otherTab.Paddingless;this.HideTabGroupIfTabGroupOnlyHasOneTab =
 this.HideTabGroupIfTabGroupOnlyHasOneTab || otherTab.HideTabGroupIfTabGroupOnlyHasOneTab;if (this.Tabs.Contains(otherTab.TabName) == false){this.Tabs.Add(otherTab.TabName);}}}IList<PropertyGroupAttribute> ISubGroupProviderAttribute.GetSubGroupAttributes(){int count
 = 0;List<PropertyGroupAttribute> result =
 new List<PropertyGroupAttribute>(this.Tabs.Count);foreach (var tab in this.Tabs){result.Add(new TabSubGroupAttribute(this.GroupID + "/" + tab, count++));}return result;}string ISubGroupProviderAttribute.RepathMemberAttribute(PropertyGroupAttribute attr){var tabAttr
 =
 (TabGroupAttribute)attr;return this.GroupID + "/" + tabAttr.TabName;}[System.Diagnostics.Conditional("UNITY_EDITOR")]public class TabSubGroupAttribute : PropertyGroupAttribute{public TabSubGroupAttribute(string groupId, float order) : base(groupId, order){}}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class TableColumnWidthAttribute : Attribute{public int Width;public bool Resizable
 = true;public TableColumnWidthAttribute(int width, bool resizable = true){this.Width = width;this.Resizable =
 resizable;}}}namespace Sirenix.OdinInspector{using System;using UnityEngine;[AttributeUsage(AttributeTargets.All, AllowMultiple
 =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class TableListAttribute : Attribute{public int NumberOfItemsPerPage;public bool IsReadOnly;public int DefaultMinColumnWidth
 = 40;public bool ShowIndexLabels;public bool DrawScrollView = true;public int MinScrollViewHeight =
 350;public int MaxScrollViewHeight;public bool AlwaysExpanded;public bool HideToolbar = false;public int CellPadding =
 2;[SerializeField, HideInInspector]private bool showPagingHasValue =
 false;[SerializeField, HideInInspector]private bool showPaging =
 false;public bool ShowPaging{get { return this.showPaging; }set{this.showPaging = value;this.showPagingHasValue =
 true;}}public bool ShowPagingHasValue { get { return this.showPagingHasValue; } }public int ScrollViewHeight{get { return Math.Min(this.MinScrollViewHeight, this.MaxScrollViewHeight); }set { this.MinScrollViewHeight
 = this.MaxScrollViewHeight =
 value; }}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class TableMatrixAttribute : Attribute{public bool IsReadOnly
 = false;public bool ResizableColumns = true;public string VerticalTitle = null;public string HorizontalTitle =
 null;public string DrawElementMethod = null;public int RowHeight = 0;public bool SquareCells =
 false;public bool HideColumnIndices = false;public bool HideRowIndices = false;public bool RespectIndentLevel =
 true;public bool Transpose =
 false;}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class TitleAttribute : Attribute{public string Title;public string Subtitle;public bool Bold;public bool HorizontalLine;public TitleAlignments TitleAlignment;public TitleAttribute(string title, string subtitle
 = null, TitleAlignments titleAlignment = TitleAlignments.Left, bool horizontalLine = true, bool bold = true){this.Title
 = title ?? "null";this.Subtitle = subtitle;this.Bold = bold;this.TitleAlignment = titleAlignment;this.HorizontalLine =
 horizontalLine;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class TitleGroupAttribute : PropertyGroupAttribute{public string Subtitle;public TitleAlignments Alignment;public bool HorizontalLine;public bool BoldTitle;public bool Indent;public TitleGroupAttribute(string title, string subtitle
 = null, TitleAlignments alignment = TitleAlignments.Left, bool horizontalLine = true, bool boldTitle =
 true, bool indent = false, float order = 0) : base(title, order){this.Subtitle = subtitle;this.Alignment =
 alignment;this.HorizontalLine = horizontalLine;this.BoldTitle = boldTitle;this.Indent =
 indent;}protected override void CombineValuesWith(PropertyGroupAttribute other){var t =
 other as TitleGroupAttribute;if (this.Subtitle != null){t.Subtitle = this.Subtitle;}else{this.Subtitle =
 t.Subtitle;}if (this.Alignment != TitleAlignments.Left){t.Alignment = this.Alignment;}else{this.Alignment =
 t.Alignment;}if (this.HorizontalLine != true){t.HorizontalLine = this.HorizontalLine;}else{this.HorizontalLine =
 t.HorizontalLine;}if (this.BoldTitle != true){t.BoldTitle = this.BoldTitle;}else{this.BoldTitle =
 t.BoldTitle;}if (this.Indent == true){t.Indent = this.Indent;}else{this.Indent =
 t.Indent;}}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ToggleAttribute : Attribute{public string ToggleMemberName;public bool CollapseOthersOnExpand;public ToggleAttribute(string toggleMemberName){this.ToggleMemberName
 = toggleMemberName;this.CollapseOthersOnExpand =
 true;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ToggleGroupAttribute : PropertyGroupAttribute{public string ToggleGroupTitle;public bool CollapseOthersOnExpand;public ToggleGroupAttribute(string toggleMemberName, float order
 = 0, string groupTitle = null): base(toggleMemberName, order){this.ToggleGroupTitle =
 groupTitle;this.CollapseOthersOnExpand =
 true;}public ToggleGroupAttribute(string toggleMemberName, string groupTitle): this(toggleMemberName, 0, groupTitle){}[Obsolete("Use [ToggleGroup(\"toggleMemberName\", groupTitle: \"$titleStringMemberName\")] instead")]public ToggleGroupAttribute(string toggleMemberName, float order, string groupTitle, string titleStringMemberName): base(toggleMemberName, order){this.ToggleGroupTitle
 = groupTitle;this.CollapseOthersOnExpand =
 true;}public string ToggleMemberName { get { return this.GroupName; } }[Obsolete("Add a $ infront of group title instead, i.e: \"$MyStringMember\".")]public string TitleStringMemberName { get; set; }protected override void CombineValuesWith(PropertyGroupAttribute other){var attr
 = other as ToggleGroupAttribute;if (this.ToggleGroupTitle == null){this.ToggleGroupTitle =
 attr.ToggleGroupTitle;}else if (attr.ToggleGroupTitle == null){attr.ToggleGroupTitle =
 this.ToggleGroupTitle;}this.CollapseOthersOnExpand =
 this.CollapseOthersOnExpand || attr.CollapseOthersOnExpand;attr.CollapseOthersOnExpand =
 this.CollapseOthersOnExpand;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ToggleLeftAttribute : Attribute{}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class TypeFilterAttribute : Attribute{[Obsolete("Use the FilterGetter member instead.",false)]public string MemberName { get { return this.FilterGetter; } set { this.FilterGetter
 =
 value; } }public string FilterGetter;public string DropdownTitle;public bool DrawValueNormally;public TypeFilterAttribute(string filterGetter){this.FilterGetter
 =
 filterGetter;}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class TypeInfoBoxAttribute : Attribute{public string Message;public TypeInfoBoxAttribute(string message){this.Message
 =
 message;}}}namespace Sirenix.OdinInspector{using System;[DontApplyToListElements][AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class ValidateInputAttribute : Attribute{public string DefaultMessage;[Obsolete("Use the Condition member instead.",false)]public string MemberName { get { return this.Condition; } set { this.Condition
 =
 value; } }public string Condition;public InfoMessageType MessageType;public bool IncludeChildren;[Obsolete("Use the ContinuousValidationCheck member instead.")]public bool ContiniousValidationCheck { get { return this.ContinuousValidationCheck; } set { this.ContinuousValidationCheck
 = value; } }public bool ContinuousValidationCheck;public ValidateInputAttribute(string condition, string defaultMessage
 = null, InfoMessageType messageType = InfoMessageType.Error){this.Condition = condition;this.DefaultMessage =
 defaultMessage;this.MessageType = messageType;this.IncludeChildren =
 true;}[Obsolete("Rejecting invalid input is no longer supported. Use the other constructor instead.", true)]public ValidateInputAttribute(string condition, string message, InfoMessageType messageType, bool rejectedInvalidInput){this.Condition
 = condition;this.DefaultMessage = message;this.MessageType = messageType;this.IncludeChildren =
 true;}}}namespace Sirenix.OdinInspector{using System;using System.Collections.Generic;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class ValueDropdownAttribute : Attribute{[Obsolete("Use the ValuesGetter member instead.",false)]public string MemberName { get { return this.ValuesGetter; } set { this.ValuesGetter
 =
 value; } }public string ValuesGetter;public int NumberOfItemsBeforeEnablingSearch;public bool IsUniqueList;public bool DrawDropdownForListElements;public bool DisableListAddButtonBehaviour;public bool ExcludeExistingValuesInList;public bool ExpandAllMenuItems;public bool AppendNextDrawer;public bool DisableGUIInAppendedDrawer;public bool DoubleClickToConfirm;public bool FlattenTreeView;public int DropdownWidth;public int DropdownHeight;public string DropdownTitle;public bool SortDropdownItems;public bool HideChildProperties
 = false;public bool CopyValues =
 true;public ValueDropdownAttribute(string valuesGetter){this.NumberOfItemsBeforeEnablingSearch = 10;this.ValuesGetter =
 valuesGetter;this.DrawDropdownForListElements =
 true;}}public interface IValueDropdownItem{string GetText();object GetValue();}public class ValueDropdownList<T> : List<ValueDropdownItem<T>>{public void Add(string text, T value){this.Add(new ValueDropdownItem<T>(text, value));}public void Add(T value){this.Add(new ValueDropdownItem<T>(value.ToString(), value));}}public struct ValueDropdownItem : IValueDropdownItem{public string Text;public object Value;public ValueDropdownItem(string text, object value){this.Text
 = text;this.Value =
 value;}public override string ToString(){return this.Text ?? (this.Value + "");}string IValueDropdownItem.GetText(){return this.Text;}object IValueDropdownItem.GetValue(){return this.Value;}}public struct ValueDropdownItem<T> : IValueDropdownItem{public string Text;public T Value;public ValueDropdownItem(string text, T value){this.Text
 = text;this.Value =
 value;}string IValueDropdownItem.GetText(){return this.Text;}object IValueDropdownItem.GetValue(){return this.Value;}public override string ToString(){return this.Text ?? (this.Value + "");}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple
 = true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class VerticalGroupAttribute : PropertyGroupAttribute{public float PaddingTop;public float PaddingBottom;public VerticalGroupAttribute(string groupId, float order
 = 0) : base(groupId, order){}public VerticalGroupAttribute(float order =
 0): this("_DefaultVerticalGroup", order){}protected override void CombineValuesWith(PropertyGroupAttribute other){var a
 = other as VerticalGroupAttribute;if (a != null){if (a.PaddingTop != 0){this.PaddingTop =
 a.PaddingTop;}if (a.PaddingBottom != 0){this.PaddingBottom =
 a.PaddingBottom;}}}}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.All, AllowMultiple =
 false, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public sealed class WrapAttribute : Attribute{public double Min;public double Max;public WrapAttribute(double min, double max){this.Min
 = min < max ? min : max;this.Max =
 max > min ? max : min;}}}namespace Sirenix.OdinInspector{using System;public static class AttributeTargetFlags{public const AttributeTargets Default
 = AttributeTargets.All;}}namespace Sirenix.OdinInspector{public enum ButtonSizes{Small = 0,Medium = 22,Large =
 31,Gigantic =
 62,}}namespace Sirenix.OdinInspector{public enum DictionaryDisplayOptions{OneLine,Foldout,CollapsedFoldout,ExpandedFoldout}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.Class)]public class IncludeMyAttributesAttribute : Attribute{}}namespace Sirenix.OdinInspector{public enum InfoMessageType{None,Info,Warning,Error}}namespace Sirenix.OdinInspector{public enum InlineEditorModes{GUIOnly
 = 0,GUIAndHeader = 1,GUIAndPreview = 2,SmallPreview = 3,LargePreview = 4,FullEditor =
 5}}namespace Sirenix.OdinInspector{public enum InlineEditorObjectFieldModes{Boxed,Foldout,Hidden,CompletelyHidden,}}namespace Sirenix.OdinInspector{public interface ISearchFilterable{bool IsMatch(string searchString);}}namespace Sirenix.OdinInspector.Internal{using System.Collections.Generic;public interface ISubGroupProviderAttribute{IList<PropertyGroupAttribute> GetSubGroupAttributes();string RepathMemberAttribute(PropertyGroupAttribute attr);}}namespace Sirenix.OdinInspector{public enum ObjectFieldAlignment{Left
 = 0,Center = 1,Right =
 2,}}namespace Sirenix.OdinInspector{using System;[AttributeUsage(AttributeTargets.Assembly, AllowMultiple =
 true, Inherited =
 true)][System.Diagnostics.Conditional("UNITY_EDITOR")]public class OdinRegisterAttributeAttribute : Attribute{public Type AttributeType;public string Categories;public string Description;public string DocumentationUrl;public bool IsEnterprise;public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise){this.AttributeType
 = attributeType;this.Categories = category;this.Description = description;this.IsEnterprise =
 isEnterprise;}public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, bool isEnterprise, string url){this.AttributeType
 = attributeType;this.Categories = category;this.Description = description;this.IsEnterprise =
 isEnterprise;this.DocumentationUrl =
 url;}}}namespace Sirenix.OdinInspector{using System;[Flags]public enum SearchFilterOptions{PropertyName =
 1 << 0,PropertyNiceName = 1 << 1,TypeOfValue = 1 << 2,ValueToString = 1 << 3,ISearchFilterableInterface = 1 << 4,All =
 ~0}}namespace Sirenix.OdinInspector{public enum TitleAlignments{Left,Centered,Right,Split,}}
#endif