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
    /// Represents a chat completion response returned by model, based on the provided input.
    /// </summary>
    [DataContract]
        public partial class CreateChatCompletionResponse :  IEquatable<CreateChatCompletionResponse>, IValidatableObject
    {
        /// <summary>
        /// The object type, which is always &#x60;chat.completion&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;chat.completion&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ObjectEnum
        {
            /// <summary>
            /// Enum ChatCompletion for value: chat.completion
            /// </summary>
            [EnumMember(Value = "chat.completion")]
            ChatCompletion = 1        }
        /// <summary>
        /// The object type, which is always &#x60;chat.completion&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;chat.completion&#x60;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum _Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">A unique identifier for the chat completion. (required).</param>
        /// <param name="choices">A list of chat completion choices. Can be more than one if &#x60;n&#x60; is greater than 1. (required).</param>
        /// <param name="created">The Unix timestamp (in seconds) of when the chat completion was created. (required).</param>
        /// <param name="model">The model used for the chat completion. (required).</param>
        /// <param name="systemFingerprint">This fingerprint represents the backend configuration that the model runs with.  Can be used in conjunction with the &#x60;seed&#x60; request parameter to understand when backend changes have been made that might impact determinism. .</param>
        /// <param name="_object">The object type, which is always &#x60;chat.completion&#x60;. (required).</param>
        /// <param name="usage">usage.</param>
        public CreateChatCompletionResponse(string id = default(string), List<CreateChatCompletionResponseChoices> choices = default(List<CreateChatCompletionResponseChoices>), int? created = default(int?), string model = default(string), string systemFingerprint = default(string), ObjectEnum _object = default(ObjectEnum), CompletionUsage usage = default(CompletionUsage))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreateChatCompletionResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "choices" is required (not null)
            if (choices == null)
            {
                throw new InvalidDataException("choices is a required property for CreateChatCompletionResponse and cannot be null");
            }
            else
            {
                this.Choices = choices;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for CreateChatCompletionResponse and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for CreateChatCompletionResponse and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for CreateChatCompletionResponse and cannot be null");
            }
            else
            {
                this._Object = _object;
            }
            this.SystemFingerprint = systemFingerprint;
            this.Usage = usage;
        }
        
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        /// <value>A unique identifier for the chat completion.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// A list of chat completion choices. Can be more than one if &#x60;n&#x60; is greater than 1.
        /// </summary>
        /// <value>A list of chat completion choices. Can be more than one if &#x60;n&#x60; is greater than 1.</value>
        [DataMember(Name="choices", EmitDefaultValue=false)]
        public List<CreateChatCompletionResponseChoices> Choices { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the chat completion was created.
        /// </summary>
        /// <value>The Unix timestamp (in seconds) of when the chat completion was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public int? Created { get; set; }

        /// <summary>
        /// The model used for the chat completion.
        /// </summary>
        /// <value>The model used for the chat completion.</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// This fingerprint represents the backend configuration that the model runs with.  Can be used in conjunction with the &#x60;seed&#x60; request parameter to understand when backend changes have been made that might impact determinism. 
        /// </summary>
        /// <value>This fingerprint represents the backend configuration that the model runs with.  Can be used in conjunction with the &#x60;seed&#x60; request parameter to understand when backend changes have been made that might impact determinism. </value>
        [DataMember(Name="system_fingerprint", EmitDefaultValue=false)]
        public string SystemFingerprint { get; set; }


        /// <summary>
        /// Gets or Sets Usage
        /// </summary>
        [DataMember(Name="usage", EmitDefaultValue=false)]
        public CompletionUsage Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChatCompletionResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  SystemFingerprint: ").Append(SystemFingerprint).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
            return this.Equals(input as CreateChatCompletionResponse);
        }

        /// <summary>
        /// Returns true if CreateChatCompletionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateChatCompletionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateChatCompletionResponse input)
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
                    this.Choices == input.Choices ||
                    this.Choices != null &&
                    input.Choices != null &&
                    this.Choices.SequenceEqual(input.Choices)
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.SystemFingerprint == input.SystemFingerprint ||
                    (this.SystemFingerprint != null &&
                    this.SystemFingerprint.Equals(input.SystemFingerprint))
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.Usage == input.Usage ||
                    (this.Usage != null &&
                    this.Usage.Equals(input.Usage))
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
                if (this.Choices != null)
                    hashCode = hashCode * 59 + this.Choices.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.SystemFingerprint != null)
                    hashCode = hashCode * 59 + this.SystemFingerprint.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Usage != null)
                    hashCode = hashCode * 59 + this.Usage.GetHashCode();
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
