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
    /// Represents a message within a [thread](/docs/api-reference/threads).
    /// </summary>
    [DataContract]
        public partial class MessageObject :  IEquatable<MessageObject>, IValidatableObject
    {
        /// <summary>
        /// The object type, which is always &#x60;thread.message&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;thread.message&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ObjectEnum
        {
            /// <summary>
            /// Enum ThreadMessage for value: thread.message
            /// </summary>
            [EnumMember(Value = "thread.message")]
            ThreadMessage = 1        }
        /// <summary>
        /// The object type, which is always &#x60;thread.message&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;thread.message&#x60;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum _Object { get; set; }
        /// <summary>
        /// The entity that produced the message. One of &#x60;user&#x60; or &#x60;assistant&#x60;.
        /// </summary>
        /// <value>The entity that produced the message. One of &#x60;user&#x60; or &#x60;assistant&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RoleEnum
        {
            /// <summary>
            /// Enum User for value: user
            /// </summary>
            [EnumMember(Value = "user")]
            User = 1,
            /// <summary>
            /// Enum Assistant for value: assistant
            /// </summary>
            [EnumMember(Value = "assistant")]
            Assistant = 2        }
        /// <summary>
        /// The entity that produced the message. One of &#x60;user&#x60; or &#x60;assistant&#x60;.
        /// </summary>
        /// <value>The entity that produced the message. One of &#x60;user&#x60; or &#x60;assistant&#x60;.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageObject" /> class.
        /// </summary>
        /// <param name="id">The identifier, which can be referenced in API endpoints. (required).</param>
        /// <param name="_object">The object type, which is always &#x60;thread.message&#x60;. (required).</param>
        /// <param name="createdAt">The Unix timestamp (in seconds) for when the message was created. (required).</param>
        /// <param name="threadId">The [thread](/docs/api-reference/threads) ID that this message belongs to. (required).</param>
        /// <param name="role">The entity that produced the message. One of &#x60;user&#x60; or &#x60;assistant&#x60;. (required).</param>
        /// <param name="content">The content of the message in array of text and/or images. (required).</param>
        /// <param name="assistantId">If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message. (required).</param>
        /// <param name="runId">If applicable, the ID of the [run](/docs/api-reference/runs) associated with the authoring of this message. (required).</param>
        /// <param name="fileIds">A list of [file](/docs/api-reference/files) IDs that the assistant should use. Useful for tools like retrieval and code_interpreter that can access files. A maximum of 10 files can be attached to a message. (required) (default to []).</param>
        /// <param name="metadata">Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.  (required).</param>
        public MessageObject(string id = default(string), ObjectEnum _object = default(ObjectEnum), int? createdAt = default(int?), string threadId = default(string), RoleEnum role = default(RoleEnum), List<OneOfMessageObjectContentItems> content = default(List<OneOfMessageObjectContentItems>), string assistantId = default(string), string runId = default(string), List<string> fileIds = default, Object metadata = default(Object))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for MessageObject and cannot be null");
            }
            else
            {
                this._Object = _object;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "threadId" is required (not null)
            if (threadId == null)
            {
                throw new InvalidDataException("threadId is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.ThreadId = threadId;
            }
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.Role = role;
            }
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new InvalidDataException("content is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.Content = content;
            }
            // to ensure "assistantId" is required (not null)
            if (assistantId == null)
            {
                throw new InvalidDataException("assistantId is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.AssistantId = assistantId;
            }
            // to ensure "runId" is required (not null)
            if (runId == null)
            {
                throw new InvalidDataException("runId is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.RunId = runId;
            }
            // to ensure "fileIds" is required (not null)
            if (fileIds == null)
            {
                throw new InvalidDataException("fileIds is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.FileIds = fileIds;
            }
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new InvalidDataException("metadata is a required property for MessageObject and cannot be null");
            }
            else
            {
                this.Metadata = metadata;
            }
        }
        
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        /// <value>The identifier, which can be referenced in API endpoints.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// The Unix timestamp (in seconds) for when the message was created.
        /// </summary>
        /// <value>The Unix timestamp (in seconds) for when the message was created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// The [thread](/docs/api-reference/threads) ID that this message belongs to.
        /// </summary>
        /// <value>The [thread](/docs/api-reference/threads) ID that this message belongs to.</value>
        [DataMember(Name="thread_id", EmitDefaultValue=false)]
        public string ThreadId { get; set; }


        /// <summary>
        /// The content of the message in array of text and/or images.
        /// </summary>
        /// <value>The content of the message in array of text and/or images.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<OneOfMessageObjectContentItems> Content { get; set; }

        /// <summary>
        /// If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message.
        /// </summary>
        /// <value>If applicable, the ID of the [assistant](/docs/api-reference/assistants) that authored this message.</value>
        [DataMember(Name="assistant_id", EmitDefaultValue=false)]
        public string AssistantId { get; set; }

        /// <summary>
        /// If applicable, the ID of the [run](/docs/api-reference/runs) associated with the authoring of this message.
        /// </summary>
        /// <value>If applicable, the ID of the [run](/docs/api-reference/runs) associated with the authoring of this message.</value>
        [DataMember(Name="run_id", EmitDefaultValue=false)]
        public string RunId { get; set; }

        /// <summary>
        /// A list of [file](/docs/api-reference/files) IDs that the assistant should use. Useful for tools like retrieval and code_interpreter that can access files. A maximum of 10 files can be attached to a message.
        /// </summary>
        /// <value>A list of [file](/docs/api-reference/files) IDs that the assistant should use. Useful for tools like retrieval and code_interpreter that can access files. A maximum of 10 files can be attached to a message.</value>
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
            sb.Append("class MessageObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  AssistantId: ").Append(AssistantId).Append("\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
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
            return this.Equals(input as MessageObject);
        }

        /// <summary>
        /// Returns true if MessageObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.ThreadId == input.ThreadId ||
                    (this.ThreadId != null &&
                    this.ThreadId.Equals(input.ThreadId))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    input.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.AssistantId == input.AssistantId ||
                    (this.AssistantId != null &&
                    this.AssistantId.Equals(input.AssistantId))
                ) && 
                (
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ThreadId != null)
                    hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.AssistantId != null)
                    hashCode = hashCode * 59 + this.AssistantId.GetHashCode();
                if (this.RunId != null)
                    hashCode = hashCode * 59 + this.RunId.GetHashCode();
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
