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
    /// ChatCompletionRequestMessageContentPartImage
    /// </summary>
    [DataContract]
        public partial class ChatCompletionRequestMessageContentPartImage :  IEquatable<ChatCompletionRequestMessageContentPartImage>, IValidatableObject, ChatCompletionRequestMessageContentPart 
    {
        /// <summary>
        /// The type of the content part.
        /// </summary>
        /// <value>The type of the content part.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Imageurl for value: image_url
            /// </summary>
            [EnumMember(Value = "image_url")]
            Imageurl = 1        }
        /// <summary>
        /// The type of the content part.
        /// </summary>
        /// <value>The type of the content part.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartImage" /> class.
        /// </summary>
        /// <param name="type">The type of the content part. (required).</param>
        /// <param name="imageUrl">imageUrl (required).</param>
        public ChatCompletionRequestMessageContentPartImage(TypeEnum type = default(TypeEnum), ChatCompletionRequestMessageContentPartImageImageUrl imageUrl = default(ChatCompletionRequestMessageContentPartImageImageUrl))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ChatCompletionRequestMessageContentPartImage and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "imageUrl" is required (not null)
            if (imageUrl == null)
            {
                throw new InvalidDataException("imageUrl is a required property for ChatCompletionRequestMessageContentPartImage and cannot be null");
            }
            else
            {
                this.ImageUrl = imageUrl;
            }
        }
        

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public ChatCompletionRequestMessageContentPartImageImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatCompletionRequestMessageContentPartImage {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(input as ChatCompletionRequestMessageContentPartImage);
        }

        /// <summary>
        /// Returns true if ChatCompletionRequestMessageContentPartImage instances are equal
        /// </summary>
        /// <param name="input">Instance of ChatCompletionRequestMessageContentPartImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatCompletionRequestMessageContentPartImage input)
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
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
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
