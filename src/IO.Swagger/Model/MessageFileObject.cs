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
    /// A list of files attached to a &#x60;message&#x60;.
    /// </summary>
    [DataContract]
        public partial class MessageFileObject :  IEquatable<MessageFileObject>, IValidatableObject
    {
        /// <summary>
        /// The object type, which is always &#x60;thread.message.file&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;thread.message.file&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ObjectEnum
        {
            /// <summary>
            /// Enum ThreadMessageFile for value: thread.message.file
            /// </summary>
            [EnumMember(Value = "thread.message.file")]
            ThreadMessageFile = 1        }
        /// <summary>
        /// The object type, which is always &#x60;thread.message.file&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;thread.message.file&#x60;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum _Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageFileObject" /> class.
        /// </summary>
        /// <param name="id">The identifier, which can be referenced in API endpoints. (required).</param>
        /// <param name="_object">The object type, which is always &#x60;thread.message.file&#x60;. (required).</param>
        /// <param name="createdAt">The Unix timestamp (in seconds) for when the message file was created. (required).</param>
        /// <param name="messageId">The ID of the [message](/docs/api-reference/messages) that the [File](/docs/api-reference/files) is attached to. (required).</param>
        public MessageFileObject(string id = default(string), ObjectEnum _object = default(ObjectEnum), int? createdAt = default(int?), string messageId = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for MessageFileObject and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for MessageFileObject and cannot be null");
            }
            else
            {
                this._Object = _object;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for MessageFileObject and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for MessageFileObject and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }
        }
        
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        /// <value>The identifier, which can be referenced in API endpoints.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// The Unix timestamp (in seconds) for when the message file was created.
        /// </summary>
        /// <value>The Unix timestamp (in seconds) for when the message file was created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// The ID of the [message](/docs/api-reference/messages) that the [File](/docs/api-reference/files) is attached to.
        /// </summary>
        /// <value>The ID of the [message](/docs/api-reference/messages) that the [File](/docs/api-reference/files) is attached to.</value>
        [DataMember(Name="message_id", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageFileObject {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
            return this.Equals(input as MessageFileObject);
        }

        /// <summary>
        /// Returns true if MessageFileObject instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageFileObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageFileObject input)
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
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
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
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
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
