/* 
 * OpenAI API
 *
 * The OpenAI REST API. Please see https://platform.openai.com/docs/api-reference for more details.
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// A URL for the file that&#x27;s generated when the assistant used the &#x60;code_interpreter&#x60; tool to generate a file.
    /// </summary>
    [DataContract]
        public partial class MessageContentTextAnnotationsFilePathObject :  IEquatable<MessageContentTextAnnotationsFilePathObject>, IValidatableObject, OneOfMessageContentTextObjectTextAnnotationsItems 
    {
        /// <summary>
        /// Always &#x60;file_path&#x60;.
        /// </summary>
        /// <value>Always &#x60;file_path&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Filepath for value: file_path
            /// </summary>
            [EnumMember(Value = "file_path")]
            Filepath = 1        }
        /// <summary>
        /// Always &#x60;file_path&#x60;.
        /// </summary>
        /// <value>Always &#x60;file_path&#x60;.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextAnnotationsFilePathObject" /> class.
        /// </summary>
        /// <param name="type">Always &#x60;file_path&#x60;. (required).</param>
        /// <param name="text">The text in the message content that needs to be replaced. (required).</param>
        /// <param name="filePath">filePath (required).</param>
        /// <param name="startIndex">startIndex (required).</param>
        /// <param name="endIndex">endIndex (required).</param>
        public MessageContentTextAnnotationsFilePathObject(TypeEnum type = default(TypeEnum), string text = default(string), MessageContentTextAnnotationsFilePathObjectFilePath filePath = default(MessageContentTextAnnotationsFilePathObjectFilePath), int? startIndex = default(int?), int? endIndex = default(int?))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for MessageContentTextAnnotationsFilePathObject and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new InvalidDataException("text is a required property for MessageContentTextAnnotationsFilePathObject and cannot be null");
            }
            else
            {
                this.Text = text;
            }
            // to ensure "filePath" is required (not null)
            if (filePath == null)
            {
                throw new InvalidDataException("filePath is a required property for MessageContentTextAnnotationsFilePathObject and cannot be null");
            }
            else
            {
                this.FilePath = filePath;
            }
            // to ensure "startIndex" is required (not null)
            if (startIndex == null)
            {
                throw new InvalidDataException("startIndex is a required property for MessageContentTextAnnotationsFilePathObject and cannot be null");
            }
            else
            {
                this.StartIndex = startIndex;
            }
            // to ensure "endIndex" is required (not null)
            if (endIndex == null)
            {
                throw new InvalidDataException("endIndex is a required property for MessageContentTextAnnotationsFilePathObject and cannot be null");
            }
            else
            {
                this.EndIndex = endIndex;
            }
        }
        

        /// <summary>
        /// The text in the message content that needs to be replaced.
        /// </summary>
        /// <value>The text in the message content that needs to be replaced.</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets FilePath
        /// </summary>
        [DataMember(Name="file_path", EmitDefaultValue=false)]
        public MessageContentTextAnnotationsFilePathObjectFilePath FilePath { get; set; }

        /// <summary>
        /// Gets or Sets StartIndex
        /// </summary>
        [DataMember(Name="start_index", EmitDefaultValue=false)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Gets or Sets EndIndex
        /// </summary>
        [DataMember(Name="end_index", EmitDefaultValue=false)]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageContentTextAnnotationsFilePathObject {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  FilePath: ").Append(FilePath).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageContentTextAnnotationsFilePathObject);
        }

        /// <summary>
        /// Returns true if MessageContentTextAnnotationsFilePathObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageContentTextAnnotationsFilePathObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageContentTextAnnotationsFilePathObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.FilePath == input.FilePath ||
                    (this.FilePath != null &&
                    this.FilePath.Equals(input.FilePath))
                ) && 
                (
                    this.StartIndex == input.StartIndex ||
                    (this.StartIndex != null &&
                    this.StartIndex.Equals(input.StartIndex))
                ) && 
                (
                    this.EndIndex == input.EndIndex ||
                    (this.EndIndex != null &&
                    this.EndIndex.Equals(input.EndIndex))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.FilePath != null)
                    hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.StartIndex != null)
                    hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.EndIndex != null)
                    hashCode = hashCode * 59 + this.EndIndex.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
