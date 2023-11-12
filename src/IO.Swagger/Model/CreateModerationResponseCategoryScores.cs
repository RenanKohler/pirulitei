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
    /// A list of the categories along with their scores as predicted by model.
    /// </summary>
    [DataContract]
        public partial class CreateModerationResponseCategoryScores :  IEquatable<CreateModerationResponseCategoryScores>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseCategoryScores" /> class.
        /// </summary>
        /// <param name="hate">The score for the category &#x27;hate&#x27;. (required).</param>
        /// <param name="hatethreatening">The score for the category &#x27;hate/threatening&#x27;. (required).</param>
        /// <param name="harassment">The score for the category &#x27;harassment&#x27;. (required).</param>
        /// <param name="harassmentthreatening">The score for the category &#x27;harassment/threatening&#x27;. (required).</param>
        /// <param name="selfHarm">The score for the category &#x27;self-harm&#x27;. (required).</param>
        /// <param name="selfHarmintent">The score for the category &#x27;self-harm/intent&#x27;. (required).</param>
        /// <param name="selfHarminstructions">The score for the category &#x27;self-harm/instructions&#x27;. (required).</param>
        /// <param name="sexual">The score for the category &#x27;sexual&#x27;. (required).</param>
        /// <param name="sexualminors">The score for the category &#x27;sexual/minors&#x27;. (required).</param>
        /// <param name="violence">The score for the category &#x27;violence&#x27;. (required).</param>
        /// <param name="violencegraphic">The score for the category &#x27;violence/graphic&#x27;. (required).</param>
        public CreateModerationResponseCategoryScores(decimal? hate = default(decimal?), decimal? hatethreatening = default(decimal?), decimal? harassment = default(decimal?), decimal? harassmentthreatening = default(decimal?), decimal? selfHarm = default(decimal?), decimal? selfHarmintent = default(decimal?), decimal? selfHarminstructions = default(decimal?), decimal? sexual = default(decimal?), decimal? sexualminors = default(decimal?), decimal? violence = default(decimal?), decimal? violencegraphic = default(decimal?))
        {
            // to ensure "hate" is required (not null)
            if (hate == null)
            {
                throw new InvalidDataException("hate is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Hate = hate;
            }
            // to ensure "hatethreatening" is required (not null)
            if (hatethreatening == null)
            {
                throw new InvalidDataException("hatethreatening is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Hatethreatening = hatethreatening;
            }
            // to ensure "harassment" is required (not null)
            if (harassment == null)
            {
                throw new InvalidDataException("harassment is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Harassment = harassment;
            }
            // to ensure "harassmentthreatening" is required (not null)
            if (harassmentthreatening == null)
            {
                throw new InvalidDataException("harassmentthreatening is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Harassmentthreatening = harassmentthreatening;
            }
            // to ensure "selfHarm" is required (not null)
            if (selfHarm == null)
            {
                throw new InvalidDataException("selfHarm is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.SelfHarm = selfHarm;
            }
            // to ensure "selfHarmintent" is required (not null)
            if (selfHarmintent == null)
            {
                throw new InvalidDataException("selfHarmintent is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.SelfHarmintent = selfHarmintent;
            }
            // to ensure "selfHarminstructions" is required (not null)
            if (selfHarminstructions == null)
            {
                throw new InvalidDataException("selfHarminstructions is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.SelfHarminstructions = selfHarminstructions;
            }
            // to ensure "sexual" is required (not null)
            if (sexual == null)
            {
                throw new InvalidDataException("sexual is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Sexual = sexual;
            }
            // to ensure "sexualminors" is required (not null)
            if (sexualminors == null)
            {
                throw new InvalidDataException("sexualminors is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Sexualminors = sexualminors;
            }
            // to ensure "violence" is required (not null)
            if (violence == null)
            {
                throw new InvalidDataException("violence is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Violence = violence;
            }
            // to ensure "violencegraphic" is required (not null)
            if (violencegraphic == null)
            {
                throw new InvalidDataException("violencegraphic is a required property for CreateModerationResponseCategoryScores and cannot be null");
            }
            else
            {
                this.Violencegraphic = violencegraphic;
            }
        }
        
        /// <summary>
        /// The score for the category &#x27;hate&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;hate&#x27;.</value>
        [DataMember(Name="hate", EmitDefaultValue=false)]
        public decimal? Hate { get; set; }

        /// <summary>
        /// The score for the category &#x27;hate/threatening&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;hate/threatening&#x27;.</value>
        [DataMember(Name="hate/threatening", EmitDefaultValue=false)]
        public decimal? Hatethreatening { get; set; }

        /// <summary>
        /// The score for the category &#x27;harassment&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;harassment&#x27;.</value>
        [DataMember(Name="harassment", EmitDefaultValue=false)]
        public decimal? Harassment { get; set; }

        /// <summary>
        /// The score for the category &#x27;harassment/threatening&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;harassment/threatening&#x27;.</value>
        [DataMember(Name="harassment/threatening", EmitDefaultValue=false)]
        public decimal? Harassmentthreatening { get; set; }

        /// <summary>
        /// The score for the category &#x27;self-harm&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;self-harm&#x27;.</value>
        [DataMember(Name="self-harm", EmitDefaultValue=false)]
        public decimal? SelfHarm { get; set; }

        /// <summary>
        /// The score for the category &#x27;self-harm/intent&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;self-harm/intent&#x27;.</value>
        [DataMember(Name="self-harm/intent", EmitDefaultValue=false)]
        public decimal? SelfHarmintent { get; set; }

        /// <summary>
        /// The score for the category &#x27;self-harm/instructions&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;self-harm/instructions&#x27;.</value>
        [DataMember(Name="self-harm/instructions", EmitDefaultValue=false)]
        public decimal? SelfHarminstructions { get; set; }

        /// <summary>
        /// The score for the category &#x27;sexual&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;sexual&#x27;.</value>
        [DataMember(Name="sexual", EmitDefaultValue=false)]
        public decimal? Sexual { get; set; }

        /// <summary>
        /// The score for the category &#x27;sexual/minors&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;sexual/minors&#x27;.</value>
        [DataMember(Name="sexual/minors", EmitDefaultValue=false)]
        public decimal? Sexualminors { get; set; }

        /// <summary>
        /// The score for the category &#x27;violence&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;violence&#x27;.</value>
        [DataMember(Name="violence", EmitDefaultValue=false)]
        public decimal? Violence { get; set; }

        /// <summary>
        /// The score for the category &#x27;violence/graphic&#x27;.
        /// </summary>
        /// <value>The score for the category &#x27;violence/graphic&#x27;.</value>
        [DataMember(Name="violence/graphic", EmitDefaultValue=false)]
        public decimal? Violencegraphic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateModerationResponseCategoryScores {\n");
            sb.Append("  Hate: ").Append(Hate).Append("\n");
            sb.Append("  Hatethreatening: ").Append(Hatethreatening).Append("\n");
            sb.Append("  Harassment: ").Append(Harassment).Append("\n");
            sb.Append("  Harassmentthreatening: ").Append(Harassmentthreatening).Append("\n");
            sb.Append("  SelfHarm: ").Append(SelfHarm).Append("\n");
            sb.Append("  SelfHarmintent: ").Append(SelfHarmintent).Append("\n");
            sb.Append("  SelfHarminstructions: ").Append(SelfHarminstructions).Append("\n");
            sb.Append("  Sexual: ").Append(Sexual).Append("\n");
            sb.Append("  Sexualminors: ").Append(Sexualminors).Append("\n");
            sb.Append("  Violence: ").Append(Violence).Append("\n");
            sb.Append("  Violencegraphic: ").Append(Violencegraphic).Append("\n");
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
            return this.Equals(input as CreateModerationResponseCategoryScores);
        }

        /// <summary>
        /// Returns true if CreateModerationResponseCategoryScores instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateModerationResponseCategoryScores to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateModerationResponseCategoryScores input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Hate == input.Hate ||
                    (this.Hate != null &&
                    this.Hate.Equals(input.Hate))
                ) && 
                (
                    this.Hatethreatening == input.Hatethreatening ||
                    (this.Hatethreatening != null &&
                    this.Hatethreatening.Equals(input.Hatethreatening))
                ) && 
                (
                    this.Harassment == input.Harassment ||
                    (this.Harassment != null &&
                    this.Harassment.Equals(input.Harassment))
                ) && 
                (
                    this.Harassmentthreatening == input.Harassmentthreatening ||
                    (this.Harassmentthreatening != null &&
                    this.Harassmentthreatening.Equals(input.Harassmentthreatening))
                ) && 
                (
                    this.SelfHarm == input.SelfHarm ||
                    (this.SelfHarm != null &&
                    this.SelfHarm.Equals(input.SelfHarm))
                ) && 
                (
                    this.SelfHarmintent == input.SelfHarmintent ||
                    (this.SelfHarmintent != null &&
                    this.SelfHarmintent.Equals(input.SelfHarmintent))
                ) && 
                (
                    this.SelfHarminstructions == input.SelfHarminstructions ||
                    (this.SelfHarminstructions != null &&
                    this.SelfHarminstructions.Equals(input.SelfHarminstructions))
                ) && 
                (
                    this.Sexual == input.Sexual ||
                    (this.Sexual != null &&
                    this.Sexual.Equals(input.Sexual))
                ) && 
                (
                    this.Sexualminors == input.Sexualminors ||
                    (this.Sexualminors != null &&
                    this.Sexualminors.Equals(input.Sexualminors))
                ) && 
                (
                    this.Violence == input.Violence ||
                    (this.Violence != null &&
                    this.Violence.Equals(input.Violence))
                ) && 
                (
                    this.Violencegraphic == input.Violencegraphic ||
                    (this.Violencegraphic != null &&
                    this.Violencegraphic.Equals(input.Violencegraphic))
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
                if (this.Hate != null)
                    hashCode = hashCode * 59 + this.Hate.GetHashCode();
                if (this.Hatethreatening != null)
                    hashCode = hashCode * 59 + this.Hatethreatening.GetHashCode();
                if (this.Harassment != null)
                    hashCode = hashCode * 59 + this.Harassment.GetHashCode();
                if (this.Harassmentthreatening != null)
                    hashCode = hashCode * 59 + this.Harassmentthreatening.GetHashCode();
                if (this.SelfHarm != null)
                    hashCode = hashCode * 59 + this.SelfHarm.GetHashCode();
                if (this.SelfHarmintent != null)
                    hashCode = hashCode * 59 + this.SelfHarmintent.GetHashCode();
                if (this.SelfHarminstructions != null)
                    hashCode = hashCode * 59 + this.SelfHarminstructions.GetHashCode();
                if (this.Sexual != null)
                    hashCode = hashCode * 59 + this.Sexual.GetHashCode();
                if (this.Sexualminors != null)
                    hashCode = hashCode * 59 + this.Sexualminors.GetHashCode();
                if (this.Violence != null)
                    hashCode = hashCode * 59 + this.Violence.GetHashCode();
                if (this.Violencegraphic != null)
                    hashCode = hashCode * 59 + this.Violencegraphic.GetHashCode();
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