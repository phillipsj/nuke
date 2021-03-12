// Generated from https://github.com/phillipsj/nuke/blob/master/build/specifications/Slack.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.Slack
{
    #region SlackMessage
    /// <summary>
    ///   Used within <see cref="SlackTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class SlackMessage : ISettingsEntity
    {
        [JsonProperty("channel")]
        public virtual string Channel { get; internal set; }
        [JsonProperty("username")]
        public virtual string Username { get; internal set; }
        /// <summary>
        ///   Slack messages may be formatted using a simple markup language similar to <a href="https://daringfireball.net/projects/markdown/">Markdown</a>. Supported formatting includes: <c>```pre```</c>, <c>`code`</c>, <c>_italic_</c>, <c>*bold*</c>, and even <c>~strike~</c>.; full details are available on our <a href="https://slack.zendesk.com/hc/en-us/articles/202288908-how-can-i-add-formatting-to-my-messages-?sid=zd-up-t0288d531-u0a5kka1k">help site</a>.
        /// </summary>
        [JsonProperty("text")]
        public virtual string Text { get; internal set; }
        /// <summary>
        ///   By default bot message text will be formatted. To disable formatting on a non-user message, set the <c>mrkdwn</c> property to <c>false</c>.
        /// </summary>
        [JsonProperty("mrkdwn")]
        public virtual bool? Markdown { get; internal set; }
        [JsonProperty("icon_emoji")]
        public virtual string Emoji { get; internal set; }
        [JsonProperty("icon_url")]
        public virtual string Icon { get; internal set; }
        /// <summary>
        ///   Attachments let you add more context to a message, making them more useful and effective.
        /// </summary>
        [JsonProperty("attachments")]
        public virtual IReadOnlyList<SlackMessageAttachment> Attachments => AttachmentsInternal.AsReadOnly();
        internal List<SlackMessageAttachment> AttachmentsInternal { get; set; } = new List<SlackMessageAttachment>();
    }
    #endregion
    #region SlackMessageAttachment
    /// <summary>
    ///   Used within <see cref="SlackTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class SlackMessageAttachment : ISettingsEntity
    {
        /// <summary>
        ///   The title is displayed as larger, bold text near the top of a message attachment.
        /// </summary>
        [JsonProperty("title")]
        public virtual string Title { get; internal set; }
        /// <summary>
        ///   Hyperlink used for the title.
        /// </summary>
        [JsonProperty("title_link")]
        public virtual string TitleLink { get; internal set; }
        /// <summary>
        ///   This is optional text that appears above the message attachment block.
        /// </summary>
        [JsonProperty("pretext")]
        public virtual string PreText { get; internal set; }
        /// <summary>
        ///   This is the main text in a message attachment, and can contain <a href="https://api.slack.com/docs/message-formatting">standard message markup</a>. The content will automatically collapse if it contains <b>700+ characters</b> or <b>5+ linebreaks</b>, and will display a "Show more..." link to expand the content. Links posted in the <c>text</c> field will not unfurl.
        /// </summary>
        [JsonProperty("text")]
        public virtual string Text { get; internal set; }
        /// <summary>
        ///   By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.
        /// </summary>
        [JsonProperty("mrkdwn_in")]
        public virtual IReadOnlyList<string> MarkdownIn => MarkdownInInternal.AsReadOnly();
        internal List<string> MarkdownInInternal { get; set; } = new List<string>();
        /// <summary>
        ///   A plain-text summary of the attachment. This text will be used in clients that don't show formatted text (eg. IRC, mobile notifications) and should not contain any markup.
        /// </summary>
        [JsonProperty("fallback")]
        public virtual string Fallback { get; internal set; }
        /// <summary>
        ///   Like traffic signals, color-coding messages can quickly communicate intent and help separate them from the flow of other messages in the timeline.<para/>An optional value that can either be one of good, warning, danger, or any hex color code (eg. #439FE0). This value is used to color the border along the left side of the message attachment.
        /// </summary>
        [JsonProperty("color")]
        public virtual string Color { get; internal set; }
        /// <summary>
        ///   Small text used to display the author's name.
        /// </summary>
        [JsonProperty("author_name")]
        public virtual string AuthorName { get; internal set; }
        /// <summary>
        ///   A valid URL that will hyperlink the <c>author_name</c> text mentioned above. Will only work if <c>author_name</c> is present.
        /// </summary>
        [JsonProperty("author_link")]
        public virtual string AuthorLink { get; internal set; }
        /// <summary>
        ///   A valid URL that displays a small 16x16px image to the left of the <c>author_name</c> text. Will only work if <c>author_name</c> is present.
        /// </summary>
        [JsonProperty("author_icon")]
        public virtual string AuthorIcon { get; internal set; }
        /// <summary>
        ///   A valid URL to an image file that will be displayed inside a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.<para/>Large images will be resized to a maximum width of 360px or a maximum height of 500px, while still maintaining the original aspect ratio.
        /// </summary>
        [JsonProperty("image_url")]
        public virtual string ImageUrl { get; internal set; }
        /// <summary>
        ///   A valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.<para/>The thumbnail's longest dimension will be scaled down to 75px while maintaining the aspect ratio of the image. The filesize of the image must also be less than 500 KB.<para/>For best results, please use images that are already 75px by 75px.
        /// </summary>
        [JsonProperty("thumb_url")]
        public virtual string ThumbUrl { get; internal set; }
        /// <summary>
        ///   Add some brief text to help contextualize and identify an attachment. Limited to 300 characters, and may be truncated further when displayed to users in environments with limited screen real estate.
        /// </summary>
        [JsonProperty("footer")]
        public virtual string Footer { get; internal set; }
        /// <summary>
        ///   To render a small icon beside your <c>footer</c> text, provide a publicly accessible URL string in the <c>footer_icon</c> field. You must also provide a <c>footer</c> for the field to be recognized.<para/>We'll render what you provide at 16px by 16px. It's best to use an image that is similarly sized.<para/>Example: <c>https://platform.slack-edge.com/img/default_application_icon.png</c>
        /// </summary>
        [JsonProperty("footer_icon")]
        public virtual string FooterIcon { get; internal set; }
        /// <summary>
        ///   Does your attachment relate to something happening at a specific time?<para/>By providing the <c>ts</c> field with an integer value in "<a href="https://en.wikipedia.org/wiki/Unix_time">epoch time</a>", the attachment will display an additional timestamp value as part of the attachment's footer.<para/>Use <c>ts</c> when referencing articles or happenings. Your message will have its own timestamp when published.<para/>Example: Providing <c>123456789</c> would result in a rendered timestamp of <em>Nov 29th, 1973</em>.
        /// </summary>
        [JsonProperty("ts")]
        public virtual string Timestamp { get; internal set; }
        /// <summary>
        ///   Fields get displayed in a table-like way.
        /// </summary>
        [JsonProperty("fields")]
        public virtual IReadOnlyList<SlackMessageField> Fields => FieldsInternal.AsReadOnly();
        internal List<SlackMessageField> FieldsInternal { get; set; } = new List<SlackMessageField>();
    }
    #endregion
    #region SlackMessageField
    /// <summary>
    ///   Used within <see cref="SlackTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class SlackMessageField : ISettingsEntity
    {
        /// <summary>
        ///   Shown as a bold heading above the <c>value</c> text. It cannot contain markup and will be escaped for you.
        /// </summary>
        [JsonProperty("title")]
        public virtual string Title { get; internal set; }
        /// <summary>
        ///   The text value of the field. It may contain <a href="https://api.slack.com/docs/message-formatting">standard message markup</a> and must be escaped as normal. May be multi-line.
        /// </summary>
        [JsonProperty("value")]
        public virtual string Value { get; internal set; }
        /// <summary>
        ///   An optional flag indicating whether the <c>value</c> is short enough to be displayed side-by-side with other values.
        /// </summary>
        [JsonProperty("short")]
        public virtual bool? Short { get; internal set; }
    }
    #endregion
    #region SlackMessageExtensions
    /// <summary>
    ///   Used within <see cref="SlackTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class SlackMessageExtensions
    {
        #region Channel
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Channel"/></em></p>
        /// </summary>
        [Pure]
        public static T SetChannel<T>(this T toolSettings, string channel) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Channel = channel;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessage.Channel"/></em></p>
        /// </summary>
        [Pure]
        public static T ResetChannel<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Channel = null;
            return toolSettings;
        }
        #endregion
        #region Username
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Username"/></em></p>
        /// </summary>
        [Pure]
        public static T SetUsername<T>(this T toolSettings, string username) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = username;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessage.Username"/></em></p>
        /// </summary>
        [Pure]
        public static T ResetUsername<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Username = null;
            return toolSettings;
        }
        #endregion
        #region Text
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Text"/></em></p>
        ///   <p>Slack messages may be formatted using a simple markup language similar to <a href="https://daringfireball.net/projects/markdown/">Markdown</a>. Supported formatting includes: <c>```pre```</c>, <c>`code`</c>, <c>_italic_</c>, <c>*bold*</c>, and even <c>~strike~</c>.; full details are available on our <a href="https://slack.zendesk.com/hc/en-us/articles/202288908-how-can-i-add-formatting-to-my-messages-?sid=zd-up-t0288d531-u0a5kka1k">help site</a>.</p>
        /// </summary>
        [Pure]
        public static T SetText<T>(this T toolSettings, string text) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = text;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessage.Text"/></em></p>
        ///   <p>Slack messages may be formatted using a simple markup language similar to <a href="https://daringfireball.net/projects/markdown/">Markdown</a>. Supported formatting includes: <c>```pre```</c>, <c>`code`</c>, <c>_italic_</c>, <c>*bold*</c>, and even <c>~strike~</c>.; full details are available on our <a href="https://slack.zendesk.com/hc/en-us/articles/202288908-how-can-i-add-formatting-to-my-messages-?sid=zd-up-t0288d531-u0a5kka1k">help site</a>.</p>
        /// </summary>
        [Pure]
        public static T ResetText<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = null;
            return toolSettings;
        }
        #endregion
        #region Markdown
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Markdown"/></em></p>
        ///   <p>By default bot message text will be formatted. To disable formatting on a non-user message, set the <c>mrkdwn</c> property to <c>false</c>.</p>
        /// </summary>
        [Pure]
        public static T SetMarkdown<T>(this T toolSettings, bool? markdown) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = markdown;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessage.Markdown"/></em></p>
        ///   <p>By default bot message text will be formatted. To disable formatting on a non-user message, set the <c>mrkdwn</c> property to <c>false</c>.</p>
        /// </summary>
        [Pure]
        public static T ResetMarkdown<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="SlackMessage.Markdown"/></em></p>
        ///   <p>By default bot message text will be formatted. To disable formatting on a non-user message, set the <c>mrkdwn</c> property to <c>false</c>.</p>
        /// </summary>
        [Pure]
        public static T EnableMarkdown<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="SlackMessage.Markdown"/></em></p>
        ///   <p>By default bot message text will be formatted. To disable formatting on a non-user message, set the <c>mrkdwn</c> property to <c>false</c>.</p>
        /// </summary>
        [Pure]
        public static T DisableMarkdown<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="SlackMessage.Markdown"/></em></p>
        ///   <p>By default bot message text will be formatted. To disable formatting on a non-user message, set the <c>mrkdwn</c> property to <c>false</c>.</p>
        /// </summary>
        [Pure]
        public static T ToggleMarkdown<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Markdown = !toolSettings.Markdown;
            return toolSettings;
        }
        #endregion
        #region Emoji
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Emoji"/></em></p>
        /// </summary>
        [Pure]
        public static T SetEmoji<T>(this T toolSettings, string emoji) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = emoji;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessage.Emoji"/></em></p>
        /// </summary>
        [Pure]
        public static T ResetEmoji<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Emoji = null;
            return toolSettings;
        }
        #endregion
        #region Icon
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Icon"/></em></p>
        /// </summary>
        [Pure]
        public static T SetIcon<T>(this T toolSettings, string icon) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Icon = icon;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessage.Icon"/></em></p>
        /// </summary>
        [Pure]
        public static T ResetIcon<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Icon = null;
            return toolSettings;
        }
        #endregion
        #region Attachments
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Attachments"/> to a new list</em></p>
        ///   <p>Attachments let you add more context to a message, making them more useful and effective.</p>
        /// </summary>
        [Pure]
        public static T SetAttachments<T>(this T toolSettings, params SlackMessageAttachment[] attachments) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachmentsInternal = attachments.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessage.Attachments"/> to a new list</em></p>
        ///   <p>Attachments let you add more context to a message, making them more useful and effective.</p>
        /// </summary>
        [Pure]
        public static T SetAttachments<T>(this T toolSettings, IEnumerable<SlackMessageAttachment> attachments) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachmentsInternal = attachments.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="SlackMessage.Attachments"/></em></p>
        ///   <p>Attachments let you add more context to a message, making them more useful and effective.</p>
        /// </summary>
        [Pure]
        public static T AddAttachments<T>(this T toolSettings, params SlackMessageAttachment[] attachments) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachmentsInternal.AddRange(attachments);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="SlackMessage.Attachments"/></em></p>
        ///   <p>Attachments let you add more context to a message, making them more useful and effective.</p>
        /// </summary>
        [Pure]
        public static T AddAttachments<T>(this T toolSettings, IEnumerable<SlackMessageAttachment> attachments) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachmentsInternal.AddRange(attachments);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="SlackMessage.Attachments"/></em></p>
        ///   <p>Attachments let you add more context to a message, making them more useful and effective.</p>
        /// </summary>
        [Pure]
        public static T ClearAttachments<T>(this T toolSettings) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AttachmentsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="SlackMessage.Attachments"/></em></p>
        ///   <p>Attachments let you add more context to a message, making them more useful and effective.</p>
        /// </summary>
        [Pure]
        public static T RemoveAttachments<T>(this T toolSettings, params SlackMessageAttachment[] attachments) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<SlackMessageAttachment>(attachments);
            toolSettings.AttachmentsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="SlackMessage.Attachments"/></em></p>
        ///   <p>Attachments let you add more context to a message, making them more useful and effective.</p>
        /// </summary>
        [Pure]
        public static T RemoveAttachments<T>(this T toolSettings, IEnumerable<SlackMessageAttachment> attachments) where T : SlackMessage
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<SlackMessageAttachment>(attachments);
            toolSettings.AttachmentsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region SlackMessageAttachmentExtensions
    /// <summary>
    ///   Used within <see cref="SlackTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class SlackMessageAttachmentExtensions
    {
        #region Title
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Title"/></em></p>
        ///   <p>The title is displayed as larger, bold text near the top of a message attachment.</p>
        /// </summary>
        [Pure]
        public static T SetTitle<T>(this T toolSettings, string title) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = title;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.Title"/></em></p>
        ///   <p>The title is displayed as larger, bold text near the top of a message attachment.</p>
        /// </summary>
        [Pure]
        public static T ResetTitle<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = null;
            return toolSettings;
        }
        #endregion
        #region TitleLink
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.TitleLink"/></em></p>
        ///   <p>Hyperlink used for the title.</p>
        /// </summary>
        [Pure]
        public static T SetTitleLink<T>(this T toolSettings, string titleLink) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TitleLink = titleLink;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.TitleLink"/></em></p>
        ///   <p>Hyperlink used for the title.</p>
        /// </summary>
        [Pure]
        public static T ResetTitleLink<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.TitleLink = null;
            return toolSettings;
        }
        #endregion
        #region PreText
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.PreText"/></em></p>
        ///   <p>This is optional text that appears above the message attachment block.</p>
        /// </summary>
        [Pure]
        public static T SetPreText<T>(this T toolSettings, string preText) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PreText = preText;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.PreText"/></em></p>
        ///   <p>This is optional text that appears above the message attachment block.</p>
        /// </summary>
        [Pure]
        public static T ResetPreText<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.PreText = null;
            return toolSettings;
        }
        #endregion
        #region Text
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Text"/></em></p>
        ///   <p>This is the main text in a message attachment, and can contain <a href="https://api.slack.com/docs/message-formatting">standard message markup</a>. The content will automatically collapse if it contains <b>700+ characters</b> or <b>5+ linebreaks</b>, and will display a "Show more..." link to expand the content. Links posted in the <c>text</c> field will not unfurl.</p>
        /// </summary>
        [Pure]
        public static T SetText<T>(this T toolSettings, string text) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = text;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.Text"/></em></p>
        ///   <p>This is the main text in a message attachment, and can contain <a href="https://api.slack.com/docs/message-formatting">standard message markup</a>. The content will automatically collapse if it contains <b>700+ characters</b> or <b>5+ linebreaks</b>, and will display a "Show more..." link to expand the content. Links posted in the <c>text</c> field will not unfurl.</p>
        /// </summary>
        [Pure]
        public static T ResetText<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Text = null;
            return toolSettings;
        }
        #endregion
        #region MarkdownIn
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.MarkdownIn"/> to a new list</em></p>
        ///   <p>By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.</p>
        /// </summary>
        [Pure]
        public static T SetMarkdownIn<T>(this T toolSettings, params string[] markdownIn) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MarkdownInInternal = markdownIn.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.MarkdownIn"/> to a new list</em></p>
        ///   <p>By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.</p>
        /// </summary>
        [Pure]
        public static T SetMarkdownIn<T>(this T toolSettings, IEnumerable<string> markdownIn) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MarkdownInInternal = markdownIn.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="SlackMessageAttachment.MarkdownIn"/></em></p>
        ///   <p>By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.</p>
        /// </summary>
        [Pure]
        public static T AddMarkdownIn<T>(this T toolSettings, params string[] markdownIn) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MarkdownInInternal.AddRange(markdownIn);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="SlackMessageAttachment.MarkdownIn"/></em></p>
        ///   <p>By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.</p>
        /// </summary>
        [Pure]
        public static T AddMarkdownIn<T>(this T toolSettings, IEnumerable<string> markdownIn) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MarkdownInInternal.AddRange(markdownIn);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="SlackMessageAttachment.MarkdownIn"/></em></p>
        ///   <p>By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.</p>
        /// </summary>
        [Pure]
        public static T ClearMarkdownIn<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.MarkdownInInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="SlackMessageAttachment.MarkdownIn"/></em></p>
        ///   <p>By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.</p>
        /// </summary>
        [Pure]
        public static T RemoveMarkdownIn<T>(this T toolSettings, params string[] markdownIn) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(markdownIn);
            toolSettings.MarkdownInInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="SlackMessageAttachment.MarkdownIn"/></em></p>
        ///   <p>By default bot message attachments will not be formatted. To enable formatting on attachment fields, set the mrkdwn_in array on each attachment to the list of fields to process.</p>
        /// </summary>
        [Pure]
        public static T RemoveMarkdownIn<T>(this T toolSettings, IEnumerable<string> markdownIn) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(markdownIn);
            toolSettings.MarkdownInInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region Fallback
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Fallback"/></em></p>
        ///   <p>A plain-text summary of the attachment. This text will be used in clients that don't show formatted text (eg. IRC, mobile notifications) and should not contain any markup.</p>
        /// </summary>
        [Pure]
        public static T SetFallback<T>(this T toolSettings, string fallback) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Fallback = fallback;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.Fallback"/></em></p>
        ///   <p>A plain-text summary of the attachment. This text will be used in clients that don't show formatted text (eg. IRC, mobile notifications) and should not contain any markup.</p>
        /// </summary>
        [Pure]
        public static T ResetFallback<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Fallback = null;
            return toolSettings;
        }
        #endregion
        #region Color
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Color"/></em></p>
        ///   <p>Like traffic signals, color-coding messages can quickly communicate intent and help separate them from the flow of other messages in the timeline.<para/>An optional value that can either be one of good, warning, danger, or any hex color code (eg. #439FE0). This value is used to color the border along the left side of the message attachment.</p>
        /// </summary>
        [Pure]
        public static T SetColor<T>(this T toolSettings, string color) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = color;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.Color"/></em></p>
        ///   <p>Like traffic signals, color-coding messages can quickly communicate intent and help separate them from the flow of other messages in the timeline.<para/>An optional value that can either be one of good, warning, danger, or any hex color code (eg. #439FE0). This value is used to color the border along the left side of the message attachment.</p>
        /// </summary>
        [Pure]
        public static T ResetColor<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Color = null;
            return toolSettings;
        }
        #endregion
        #region AuthorName
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.AuthorName"/></em></p>
        ///   <p>Small text used to display the author's name.</p>
        /// </summary>
        [Pure]
        public static T SetAuthorName<T>(this T toolSettings, string authorName) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorName = authorName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.AuthorName"/></em></p>
        ///   <p>Small text used to display the author's name.</p>
        /// </summary>
        [Pure]
        public static T ResetAuthorName<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorName = null;
            return toolSettings;
        }
        #endregion
        #region AuthorLink
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.AuthorLink"/></em></p>
        ///   <p>A valid URL that will hyperlink the <c>author_name</c> text mentioned above. Will only work if <c>author_name</c> is present.</p>
        /// </summary>
        [Pure]
        public static T SetAuthorLink<T>(this T toolSettings, string authorLink) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorLink = authorLink;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.AuthorLink"/></em></p>
        ///   <p>A valid URL that will hyperlink the <c>author_name</c> text mentioned above. Will only work if <c>author_name</c> is present.</p>
        /// </summary>
        [Pure]
        public static T ResetAuthorLink<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorLink = null;
            return toolSettings;
        }
        #endregion
        #region AuthorIcon
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.AuthorIcon"/></em></p>
        ///   <p>A valid URL that displays a small 16x16px image to the left of the <c>author_name</c> text. Will only work if <c>author_name</c> is present.</p>
        /// </summary>
        [Pure]
        public static T SetAuthorIcon<T>(this T toolSettings, string authorIcon) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorIcon = authorIcon;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.AuthorIcon"/></em></p>
        ///   <p>A valid URL that displays a small 16x16px image to the left of the <c>author_name</c> text. Will only work if <c>author_name</c> is present.</p>
        /// </summary>
        [Pure]
        public static T ResetAuthorIcon<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.AuthorIcon = null;
            return toolSettings;
        }
        #endregion
        #region ImageUrl
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.ImageUrl"/></em></p>
        ///   <p>A valid URL to an image file that will be displayed inside a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.<para/>Large images will be resized to a maximum width of 360px or a maximum height of 500px, while still maintaining the original aspect ratio.</p>
        /// </summary>
        [Pure]
        public static T SetImageUrl<T>(this T toolSettings, string imageUrl) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageUrl = imageUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.ImageUrl"/></em></p>
        ///   <p>A valid URL to an image file that will be displayed inside a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.<para/>Large images will be resized to a maximum width of 360px or a maximum height of 500px, while still maintaining the original aspect ratio.</p>
        /// </summary>
        [Pure]
        public static T ResetImageUrl<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ImageUrl = null;
            return toolSettings;
        }
        #endregion
        #region ThumbUrl
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.ThumbUrl"/></em></p>
        ///   <p>A valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.<para/>The thumbnail's longest dimension will be scaled down to 75px while maintaining the aspect ratio of the image. The filesize of the image must also be less than 500 KB.<para/>For best results, please use images that are already 75px by 75px.</p>
        /// </summary>
        [Pure]
        public static T SetThumbUrl<T>(this T toolSettings, string thumbUrl) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThumbUrl = thumbUrl;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.ThumbUrl"/></em></p>
        ///   <p>A valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment. We currently support the following formats: GIF, JPEG, PNG, and BMP.<para/>The thumbnail's longest dimension will be scaled down to 75px while maintaining the aspect ratio of the image. The filesize of the image must also be less than 500 KB.<para/>For best results, please use images that are already 75px by 75px.</p>
        /// </summary>
        [Pure]
        public static T ResetThumbUrl<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ThumbUrl = null;
            return toolSettings;
        }
        #endregion
        #region Footer
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Footer"/></em></p>
        ///   <p>Add some brief text to help contextualize and identify an attachment. Limited to 300 characters, and may be truncated further when displayed to users in environments with limited screen real estate.</p>
        /// </summary>
        [Pure]
        public static T SetFooter<T>(this T toolSettings, string footer) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Footer = footer;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.Footer"/></em></p>
        ///   <p>Add some brief text to help contextualize and identify an attachment. Limited to 300 characters, and may be truncated further when displayed to users in environments with limited screen real estate.</p>
        /// </summary>
        [Pure]
        public static T ResetFooter<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Footer = null;
            return toolSettings;
        }
        #endregion
        #region FooterIcon
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.FooterIcon"/></em></p>
        ///   <p>To render a small icon beside your <c>footer</c> text, provide a publicly accessible URL string in the <c>footer_icon</c> field. You must also provide a <c>footer</c> for the field to be recognized.<para/>We'll render what you provide at 16px by 16px. It's best to use an image that is similarly sized.<para/>Example: <c>https://platform.slack-edge.com/img/default_application_icon.png</c></p>
        /// </summary>
        [Pure]
        public static T SetFooterIcon<T>(this T toolSettings, string footerIcon) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FooterIcon = footerIcon;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.FooterIcon"/></em></p>
        ///   <p>To render a small icon beside your <c>footer</c> text, provide a publicly accessible URL string in the <c>footer_icon</c> field. You must also provide a <c>footer</c> for the field to be recognized.<para/>We'll render what you provide at 16px by 16px. It's best to use an image that is similarly sized.<para/>Example: <c>https://platform.slack-edge.com/img/default_application_icon.png</c></p>
        /// </summary>
        [Pure]
        public static T ResetFooterIcon<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FooterIcon = null;
            return toolSettings;
        }
        #endregion
        #region Timestamp
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Timestamp"/></em></p>
        ///   <p>Does your attachment relate to something happening at a specific time?<para/>By providing the <c>ts</c> field with an integer value in "<a href="https://en.wikipedia.org/wiki/Unix_time">epoch time</a>", the attachment will display an additional timestamp value as part of the attachment's footer.<para/>Use <c>ts</c> when referencing articles or happenings. Your message will have its own timestamp when published.<para/>Example: Providing <c>123456789</c> would result in a rendered timestamp of <em>Nov 29th, 1973</em>.</p>
        /// </summary>
        [Pure]
        public static T SetTimestamp<T>(this T toolSettings, string timestamp) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timestamp = timestamp;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageAttachment.Timestamp"/></em></p>
        ///   <p>Does your attachment relate to something happening at a specific time?<para/>By providing the <c>ts</c> field with an integer value in "<a href="https://en.wikipedia.org/wiki/Unix_time">epoch time</a>", the attachment will display an additional timestamp value as part of the attachment's footer.<para/>Use <c>ts</c> when referencing articles or happenings. Your message will have its own timestamp when published.<para/>Example: Providing <c>123456789</c> would result in a rendered timestamp of <em>Nov 29th, 1973</em>.</p>
        /// </summary>
        [Pure]
        public static T ResetTimestamp<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timestamp = null;
            return toolSettings;
        }
        #endregion
        #region Fields
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Fields"/> to a new list</em></p>
        ///   <p>Fields get displayed in a table-like way.</p>
        /// </summary>
        [Pure]
        public static T SetFields<T>(this T toolSettings, params SlackMessageField[] fields) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal = fields.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageAttachment.Fields"/> to a new list</em></p>
        ///   <p>Fields get displayed in a table-like way.</p>
        /// </summary>
        [Pure]
        public static T SetFields<T>(this T toolSettings, IEnumerable<SlackMessageField> fields) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal = fields.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="SlackMessageAttachment.Fields"/></em></p>
        ///   <p>Fields get displayed in a table-like way.</p>
        /// </summary>
        [Pure]
        public static T AddFields<T>(this T toolSettings, params SlackMessageField[] fields) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.AddRange(fields);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="SlackMessageAttachment.Fields"/></em></p>
        ///   <p>Fields get displayed in a table-like way.</p>
        /// </summary>
        [Pure]
        public static T AddFields<T>(this T toolSettings, IEnumerable<SlackMessageField> fields) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.AddRange(fields);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="SlackMessageAttachment.Fields"/></em></p>
        ///   <p>Fields get displayed in a table-like way.</p>
        /// </summary>
        [Pure]
        public static T ClearFields<T>(this T toolSettings) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.FieldsInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="SlackMessageAttachment.Fields"/></em></p>
        ///   <p>Fields get displayed in a table-like way.</p>
        /// </summary>
        [Pure]
        public static T RemoveFields<T>(this T toolSettings, params SlackMessageField[] fields) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<SlackMessageField>(fields);
            toolSettings.FieldsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="SlackMessageAttachment.Fields"/></em></p>
        ///   <p>Fields get displayed in a table-like way.</p>
        /// </summary>
        [Pure]
        public static T RemoveFields<T>(this T toolSettings, IEnumerable<SlackMessageField> fields) where T : SlackMessageAttachment
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<SlackMessageField>(fields);
            toolSettings.FieldsInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region SlackMessageFieldExtensions
    /// <summary>
    ///   Used within <see cref="SlackTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class SlackMessageFieldExtensions
    {
        #region Title
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageField.Title"/></em></p>
        ///   <p>Shown as a bold heading above the <c>value</c> text. It cannot contain markup and will be escaped for you.</p>
        /// </summary>
        [Pure]
        public static T SetTitle<T>(this T toolSettings, string title) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = title;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageField.Title"/></em></p>
        ///   <p>Shown as a bold heading above the <c>value</c> text. It cannot contain markup and will be escaped for you.</p>
        /// </summary>
        [Pure]
        public static T ResetTitle<T>(this T toolSettings) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Title = null;
            return toolSettings;
        }
        #endregion
        #region Value
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageField.Value"/></em></p>
        ///   <p>The text value of the field. It may contain <a href="https://api.slack.com/docs/message-formatting">standard message markup</a> and must be escaped as normal. May be multi-line.</p>
        /// </summary>
        [Pure]
        public static T SetValue<T>(this T toolSettings, string value) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = value;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageField.Value"/></em></p>
        ///   <p>The text value of the field. It may contain <a href="https://api.slack.com/docs/message-formatting">standard message markup</a> and must be escaped as normal. May be multi-line.</p>
        /// </summary>
        [Pure]
        public static T ResetValue<T>(this T toolSettings) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Value = null;
            return toolSettings;
        }
        #endregion
        #region Short
        /// <summary>
        ///   <p><em>Sets <see cref="SlackMessageField.Short"/></em></p>
        ///   <p>An optional flag indicating whether the <c>value</c> is short enough to be displayed side-by-side with other values.</p>
        /// </summary>
        [Pure]
        public static T SetShort<T>(this T toolSettings, bool? @short) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = @short;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="SlackMessageField.Short"/></em></p>
        ///   <p>An optional flag indicating whether the <c>value</c> is short enough to be displayed side-by-side with other values.</p>
        /// </summary>
        [Pure]
        public static T ResetShort<T>(this T toolSettings) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="SlackMessageField.Short"/></em></p>
        ///   <p>An optional flag indicating whether the <c>value</c> is short enough to be displayed side-by-side with other values.</p>
        /// </summary>
        [Pure]
        public static T EnableShort<T>(this T toolSettings) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="SlackMessageField.Short"/></em></p>
        ///   <p>An optional flag indicating whether the <c>value</c> is short enough to be displayed side-by-side with other values.</p>
        /// </summary>
        [Pure]
        public static T DisableShort<T>(this T toolSettings) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="SlackMessageField.Short"/></em></p>
        ///   <p>An optional flag indicating whether the <c>value</c> is short enough to be displayed side-by-side with other values.</p>
        /// </summary>
        [Pure]
        public static T ToggleShort<T>(this T toolSettings) where T : SlackMessageField
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Short = !toolSettings.Short;
            return toolSettings;
        }
        #endregion
    }
    #endregion
}
