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
    /// Represents policy compliance report by OpenAI&#x27;s content moderation model against a given input.
    /// </summary>
    [DataContract]
        public partial class CreateModerationResponse :  IEquatable<CreateModerationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponse" /> class.
        /// </summary>
        /// <param name="id">The unique identifier for the moderation request. (required).</param>
        /// <param name="model">The model used to generate the moderation results. (required).</param>
        /// <param name="results">A list of moderation objects. (required).</param>
        public CreateModerationResponse(string id = default(string), string model = default(string), List<CreateModerationResponseResults> results = default(List<CreateModerationResponseResults>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreateModerationResponse and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for CreateModerationResponse and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new InvalidDataException("results is a required property for CreateModerationResponse and cannot be null");
            }
            else
            {
                this.Results = results;
            }
        }
        
        /// <summary>
        /// The unique identifier for the moderation request.
        /// </summary>
        /// <value>The unique identifier for the moderation request.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The model used to generate the moderation results.
        /// </summary>
        /// <value>The model used to generate the moderation results.</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// A list of moderation objects.
        /// </summary>
        /// <value>A list of moderation objects.</value>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<CreateModerationResponseResults> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateModerationResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as CreateModerationResponse);
        }

        /// <summary>
        /// Returns true if CreateModerationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateModerationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateModerationResponse input)
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
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    input.Results != null &&
                    this.Results.SequenceEqual(input.Results)
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
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
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
