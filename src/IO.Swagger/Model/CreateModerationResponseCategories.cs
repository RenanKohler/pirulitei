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
    /// A list of the categories, and whether they are flagged or not.
    /// </summary>
    [DataContract]
        public partial class CreateModerationResponseCategories :  IEquatable<CreateModerationResponseCategories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationResponseCategories" /> class.
        /// </summary>
        /// <param name="hate">Content that expresses, incites, or promotes hate based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste. Hateful content aimed at non-protected groups (e.g., chess players) is harrassment. (required).</param>
        /// <param name="hatethreatening">Hateful content that also includes violence or serious harm towards the targeted group based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste. (required).</param>
        /// <param name="harassment">Content that expresses, incites, or promotes harassing language towards any target. (required).</param>
        /// <param name="harassmentthreatening">Harassment content that also includes violence or serious harm towards any target. (required).</param>
        /// <param name="selfHarm">Content that promotes, encourages, or depicts acts of self-harm, such as suicide, cutting, and eating disorders. (required).</param>
        /// <param name="selfHarmintent">Content where the speaker expresses that they are engaging or intend to engage in acts of self-harm, such as suicide, cutting, and eating disorders. (required).</param>
        /// <param name="selfHarminstructions">Content that encourages performing acts of self-harm, such as suicide, cutting, and eating disorders, or that gives instructions or advice on how to commit such acts. (required).</param>
        /// <param name="sexual">Content meant to arouse sexual excitement, such as the description of sexual activity, or that promotes sexual services (excluding sex education and wellness). (required).</param>
        /// <param name="sexualminors">Sexual content that includes an individual who is under 18 years old. (required).</param>
        /// <param name="violence">Content that depicts death, violence, or physical injury. (required).</param>
        /// <param name="violencegraphic">Content that depicts death, violence, or physical injury in graphic detail. (required).</param>
        public CreateModerationResponseCategories(bool? hate = default(bool?), bool? hatethreatening = default(bool?), bool? harassment = default(bool?), bool? harassmentthreatening = default(bool?), bool? selfHarm = default(bool?), bool? selfHarmintent = default(bool?), bool? selfHarminstructions = default(bool?), bool? sexual = default(bool?), bool? sexualminors = default(bool?), bool? violence = default(bool?), bool? violencegraphic = default(bool?))
        {
            // to ensure "hate" is required (not null)
            if (hate == null)
            {
                throw new InvalidDataException("hate is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Hate = hate;
            }
            // to ensure "hatethreatening" is required (not null)
            if (hatethreatening == null)
            {
                throw new InvalidDataException("hatethreatening is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Hatethreatening = hatethreatening;
            }
            // to ensure "harassment" is required (not null)
            if (harassment == null)
            {
                throw new InvalidDataException("harassment is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Harassment = harassment;
            }
            // to ensure "harassmentthreatening" is required (not null)
            if (harassmentthreatening == null)
            {
                throw new InvalidDataException("harassmentthreatening is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Harassmentthreatening = harassmentthreatening;
            }
            // to ensure "selfHarm" is required (not null)
            if (selfHarm == null)
            {
                throw new InvalidDataException("selfHarm is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.SelfHarm = selfHarm;
            }
            // to ensure "selfHarmintent" is required (not null)
            if (selfHarmintent == null)
            {
                throw new InvalidDataException("selfHarmintent is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.SelfHarmintent = selfHarmintent;
            }
            // to ensure "selfHarminstructions" is required (not null)
            if (selfHarminstructions == null)
            {
                throw new InvalidDataException("selfHarminstructions is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.SelfHarminstructions = selfHarminstructions;
            }
            // to ensure "sexual" is required (not null)
            if (sexual == null)
            {
                throw new InvalidDataException("sexual is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Sexual = sexual;
            }
            // to ensure "sexualminors" is required (not null)
            if (sexualminors == null)
            {
                throw new InvalidDataException("sexualminors is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Sexualminors = sexualminors;
            }
            // to ensure "violence" is required (not null)
            if (violence == null)
            {
                throw new InvalidDataException("violence is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Violence = violence;
            }
            // to ensure "violencegraphic" is required (not null)
            if (violencegraphic == null)
            {
                throw new InvalidDataException("violencegraphic is a required property for CreateModerationResponseCategories and cannot be null");
            }
            else
            {
                this.Violencegraphic = violencegraphic;
            }
        }
        
        /// <summary>
        /// Content that expresses, incites, or promotes hate based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste. Hateful content aimed at non-protected groups (e.g., chess players) is harrassment.
        /// </summary>
        /// <value>Content that expresses, incites, or promotes hate based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste. Hateful content aimed at non-protected groups (e.g., chess players) is harrassment.</value>
        [DataMember(Name="hate", EmitDefaultValue=false)]
        public bool? Hate { get; set; }

        /// <summary>
        /// Hateful content that also includes violence or serious harm towards the targeted group based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste.
        /// </summary>
        /// <value>Hateful content that also includes violence or serious harm towards the targeted group based on race, gender, ethnicity, religion, nationality, sexual orientation, disability status, or caste.</value>
        [DataMember(Name="hate/threatening", EmitDefaultValue=false)]
        public bool? Hatethreatening { get; set; }

        /// <summary>
        /// Content that expresses, incites, or promotes harassing language towards any target.
        /// </summary>
        /// <value>Content that expresses, incites, or promotes harassing language towards any target.</value>
        [DataMember(Name="harassment", EmitDefaultValue=false)]
        public bool? Harassment { get; set; }

        /// <summary>
        /// Harassment content that also includes violence or serious harm towards any target.
        /// </summary>
        /// <value>Harassment content that also includes violence or serious harm towards any target.</value>
        [DataMember(Name="harassment/threatening", EmitDefaultValue=false)]
        public bool? Harassmentthreatening { get; set; }

        /// <summary>
        /// Content that promotes, encourages, or depicts acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </summary>
        /// <value>Content that promotes, encourages, or depicts acts of self-harm, such as suicide, cutting, and eating disorders.</value>
        [DataMember(Name="self-harm", EmitDefaultValue=false)]
        public bool? SelfHarm { get; set; }

        /// <summary>
        /// Content where the speaker expresses that they are engaging or intend to engage in acts of self-harm, such as suicide, cutting, and eating disorders.
        /// </summary>
        /// <value>Content where the speaker expresses that they are engaging or intend to engage in acts of self-harm, such as suicide, cutting, and eating disorders.</value>
        [DataMember(Name="self-harm/intent", EmitDefaultValue=false)]
        public bool? SelfHarmintent { get; set; }

        /// <summary>
        /// Content that encourages performing acts of self-harm, such as suicide, cutting, and eating disorders, or that gives instructions or advice on how to commit such acts.
        /// </summary>
        /// <value>Content that encourages performing acts of self-harm, such as suicide, cutting, and eating disorders, or that gives instructions or advice on how to commit such acts.</value>
        [DataMember(Name="self-harm/instructions", EmitDefaultValue=false)]
        public bool? SelfHarminstructions { get; set; }

        /// <summary>
        /// Content meant to arouse sexual excitement, such as the description of sexual activity, or that promotes sexual services (excluding sex education and wellness).
        /// </summary>
        /// <value>Content meant to arouse sexual excitement, such as the description of sexual activity, or that promotes sexual services (excluding sex education and wellness).</value>
        [DataMember(Name="sexual", EmitDefaultValue=false)]
        public bool? Sexual { get; set; }

        /// <summary>
        /// Sexual content that includes an individual who is under 18 years old.
        /// </summary>
        /// <value>Sexual content that includes an individual who is under 18 years old.</value>
        [DataMember(Name="sexual/minors", EmitDefaultValue=false)]
        public bool? Sexualminors { get; set; }

        /// <summary>
        /// Content that depicts death, violence, or physical injury.
        /// </summary>
        /// <value>Content that depicts death, violence, or physical injury.</value>
        [DataMember(Name="violence", EmitDefaultValue=false)]
        public bool? Violence { get; set; }

        /// <summary>
        /// Content that depicts death, violence, or physical injury in graphic detail.
        /// </summary>
        /// <value>Content that depicts death, violence, or physical injury in graphic detail.</value>
        [DataMember(Name="violence/graphic", EmitDefaultValue=false)]
        public bool? Violencegraphic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateModerationResponseCategories {\n");
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
            return this.Equals(input as CreateModerationResponseCategories);
        }

        /// <summary>
        /// Returns true if CreateModerationResponseCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateModerationResponseCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateModerationResponseCategories input)
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
