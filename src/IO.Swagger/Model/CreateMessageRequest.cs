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
    /// CreateMessageRequest
    /// </summary>
    [DataContract]
        public partial class CreateMessageRequest :  IEquatable<CreateMessageRequest>, IValidatableObject
    {
        /// <summary>
        /// The role of the entity that is creating the message. Currently only &#x60;user&#x60; is supported.
        /// </summary>
        /// <value>The role of the entity that is creating the message. Currently only &#x60;user&#x60; is supported.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1        }
        /// <summary>
        /// The role of the entity that is creating the message. Currently only &#x60;user&#x60; is supported.
        /// </summary>
        /// <value>The role of the entity that is creating the message. Currently only &#x60;user&#x60; is supported.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessageRequest" /> class.
        /// </summary>
        /// <param name="role">The role of the entity that is creating the message. Currently only &#x60;user&#x60; is supported. (required).</param>
        /// <param name="content">The content of the message. (required).</param>
        /// <param name="fileIds">A list of [File](/docs/api-reference/files) IDs that the message should use. There can be a maximum of 10 files attached to a message. Useful for tools like &#x60;retrieval&#x60; and &#x60;code_interpreter&#x60; that can access and use files. (default to []).</param>
        /// <param name="metadata">Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. .</param>
        public CreateMessageRequest(RoleEnum role = default(RoleEnum), string content = default(string), List<string> fileIds = default, Object metadata = default(Object))
        {
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for CreateMessageRequest and cannot be null");
            }
            else
            {
                this.Role = role;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for CreateMessageRequest and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // use default value if no "fileIds" provided
            if (fileIds == null)
            {
                this.FileIds = default;
            }
            else
            {
                this.FileIds = fileIds;
            }
            this.Metadata = metadata;
        }
        

        /// <summary>
        /// The content of the message.
        /// </summary>
        /// <value>The content of the message.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// A list of [File](/docs/api-reference/files) IDs that the message should use. There can be a maximum of 10 files attached to a message. Useful for tools like &#x60;retrieval&#x60; and &#x60;code_interpreter&#x60; that can access and use files.
        /// </summary>
        /// <value>A list of [File](/docs/api-reference/files) IDs that the message should use. There can be a maximum of 10 files attached to a message. Useful for tools like &#x60;retrieval&#x60; and &#x60;code_interpreter&#x60; that can access and use files.</value>
        [DataMember(Name="file_ids", EmitDefaultValue=false)]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. 
        /// </summary>
        /// <value>Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long. </value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateMessageRequest {\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as CreateMessageRequest);
        }

        /// <summary>
        /// Returns true if CreateMessageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateMessageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateMessageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.FileIds == input.FileIds ||
                    this.FileIds != null &&
                    input.FileIds != null &&
                    this.FileIds.SequenceEqual(input.FileIds)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.FileIds != null)
                    hashCode = hashCode * 59 + this.FileIds.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
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
