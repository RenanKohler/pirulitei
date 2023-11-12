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
    /// CreateEditResponse
    /// </summary>
    [DataContract]
        public partial class CreateEditResponse :  IEquatable<CreateEditResponse>, IValidatableObject
    {
        /// <summary>
        /// The object type, which is always &#x60;edit&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;edit&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ObjectEnum
        {
            /// <summary>
            /// Enum Edit for value: edit
            /// </summary>
            [EnumMember(Value = "edit")]
            Edit = 1        }
        /// <summary>
        /// The object type, which is always &#x60;edit&#x60;.
        /// </summary>
        /// <value>The object type, which is always &#x60;edit&#x60;.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public ObjectEnum _Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEditResponse" /> class.
        /// </summary>
        /// <param name="choices">A list of edit choices. Can be more than one if &#x60;n&#x60; is greater than 1. (required).</param>
        /// <param name="_object">The object type, which is always &#x60;edit&#x60;. (required).</param>
        /// <param name="created">The Unix timestamp (in seconds) of when the edit was created. (required).</param>
        /// <param name="usage">usage (required).</param>
        public CreateEditResponse(List<CreateEditResponseChoices> choices = default(List<CreateEditResponseChoices>), ObjectEnum _object = default(ObjectEnum), int? created = default(int?), CompletionUsage usage = default(CompletionUsage))
        {
            // to ensure "choices" is required (not null)
            if (choices == null)
            {
                throw new InvalidDataException("choices is a required property for CreateEditResponse and cannot be null");
            }
            else
            {
                this.Choices = choices;
            }
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for CreateEditResponse and cannot be null");
            }
            else
            {
                this._Object = _object;
            }
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new InvalidDataException("created is a required property for CreateEditResponse and cannot be null");
            }
            else
            {
                this.Created = created;
            }
            // to ensure "usage" is required (not null)
            if (usage == null)
            {
                throw new InvalidDataException("usage is a required property for CreateEditResponse and cannot be null");
            }
            else
            {
                this.Usage = usage;
            }
        }
        
        /// <summary>
        /// A list of edit choices. Can be more than one if &#x60;n&#x60; is greater than 1.
        /// </summary>
        /// <value>A list of edit choices. Can be more than one if &#x60;n&#x60; is greater than 1.</value>
        [DataMember(Name="choices", EmitDefaultValue=false)]
        public List<CreateEditResponseChoices> Choices { get; set; }


        /// <summary>
        /// The Unix timestamp (in seconds) of when the edit was created.
        /// </summary>
        /// <value>The Unix timestamp (in seconds) of when the edit was created.</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public int? Created { get; set; }

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
            sb.Append("class CreateEditResponse {\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
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
            return this.Equals(input as CreateEditResponse);
        }

        /// <summary>
        /// Returns true if CreateEditResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateEditResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEditResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Choices == input.Choices ||
                    this.Choices != null &&
                    input.Choices != null &&
                    this.Choices.SequenceEqual(input.Choices)
                ) && 
                (
                    this._Object == input._Object ||
                    (this._Object != null &&
                    this._Object.Equals(input._Object))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
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
                if (this.Choices != null)
                    hashCode = hashCode * 59 + this.Choices.GetHashCode();
                if (this._Object != null)
                    hashCode = hashCode * 59 + this._Object.GetHashCode();
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
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
