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
    /// CreateImageEditRequest
    /// </summary>
    [DataContract]
        public partial class CreateImageEditRequest :  IEquatable<CreateImageEditRequest>, IValidatableObject
    {
        /// <summary>
        /// The size of the generated images. Must be one of &#x60;256x256&#x60;, &#x60;512x512&#x60;, or &#x60;1024x1024&#x60;.
        /// </summary>
        /// <value>The size of the generated images. Must be one of &#x60;256x256&#x60;, &#x60;512x512&#x60;, or &#x60;1024x1024&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SizeEnum
        {
            /// <summary>
            /// Enum _256x256 for value: 256x256
            /// </summary>
            [EnumMember(Value = "256x256")]
            _256x256 = 1,
            /// <summary>
            /// Enum _512x512 for value: 512x512
            /// </summary>
            [EnumMember(Value = "512x512")]
            _512x512 = 2,
            /// <summary>
            /// Enum _1024x1024 for value: 1024x1024
            /// </summary>
            [EnumMember(Value = "1024x1024")]
            _1024x1024 = 3        }
        /// <summary>
        /// The size of the generated images. Must be one of &#x60;256x256&#x60;, &#x60;512x512&#x60;, or &#x60;1024x1024&#x60;.
        /// </summary>
        /// <value>The size of the generated images. Must be one of &#x60;256x256&#x60;, &#x60;512x512&#x60;, or &#x60;1024x1024&#x60;.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public SizeEnum? Size { get; set; }
        /// <summary>
        /// The format in which the generated images are returned. Must be one of &#x60;url&#x60; or &#x60;b64_json&#x60;.
        /// </summary>
        /// <value>The format in which the generated images are returned. Must be one of &#x60;url&#x60; or &#x60;b64_json&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ResponseFormatEnum
        {
            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 1,
            /// <summary>
            /// Enum B64json for value: b64_json
            /// </summary>
            [EnumMember(Value = "b64_json")]
            B64json = 2        }
        /// <summary>
        /// The format in which the generated images are returned. Must be one of &#x60;url&#x60; or &#x60;b64_json&#x60;.
        /// </summary>
        /// <value>The format in which the generated images are returned. Must be one of &#x60;url&#x60; or &#x60;b64_json&#x60;.</value>
        [DataMember(Name="response_format", EmitDefaultValue=false)]
        public ResponseFormatEnum? ResponseFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateImageEditRequest" /> class.
        /// </summary>
        /// <param name="image">The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not provided, image must have transparency, which will be used as the mask. (required).</param>
        /// <param name="prompt">A text description of the desired image(s). The maximum length is 1000 characters. (required).</param>
        /// <param name="mask">An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where &#x60;image&#x60; should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as &#x60;image&#x60;..</param>
        /// <param name="model">The model to use for image generation. Only &#x60;dall-e-2&#x60; is supported at this time. (default to dall-e-2).</param>
        /// <param name="n">The number of images to generate. Must be between 1 and 10. (default to 1).</param>
        /// <param name="size">The size of the generated images. Must be one of &#x60;256x256&#x60;, &#x60;512x512&#x60;, or &#x60;1024x1024&#x60;. (default to SizeEnum._1024x1024).</param>
        /// <param name="responseFormat">The format in which the generated images are returned. Must be one of &#x60;url&#x60; or &#x60;b64_json&#x60;. (default to ResponseFormatEnum.Url).</param>
        /// <param name="user">A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids). .</param>
        public CreateImageEditRequest(byte[] image = default(byte[]), string prompt = default(string), byte[] mask = default(byte[]), AnyOfCreateImageEditRequestModel model = default, int? n = 1, SizeEnum? size = SizeEnum._1024x1024, ResponseFormatEnum? responseFormat = ResponseFormatEnum.Url, string user = default(string))
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new InvalidDataException("image is a required property for CreateImageEditRequest and cannot be null");
            }
            else
            {
                this.Image = image;
            }
            // to ensure "prompt" is required (not null)
            if (prompt == null)
            {
                throw new InvalidDataException("prompt is a required property for CreateImageEditRequest and cannot be null");
            }
            else
            {
                this.Prompt = prompt;
            }
            this.Mask = mask;
            // use default value if no "model" provided
            if (model == null)
            {
                this.Model =default;
            }
            else
            {
                this.Model = model;
            }
            // use default value if no "n" provided
            if (n == null)
            {
                this.N = 1;
            }
            else
            {
                this.N = n;
            }
            // use default value if no "size" provided
            if (size == null)
            {
                this.Size = SizeEnum._1024x1024;
            }
            else
            {
                this.Size = size;
            }
            // use default value if no "responseFormat" provided
            if (responseFormat == null)
            {
                this.ResponseFormat = ResponseFormatEnum.Url;
            }
            else
            {
                this.ResponseFormat = responseFormat;
            }
            this.User = user;
        }
        
        /// <summary>
        /// The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not provided, image must have transparency, which will be used as the mask.
        /// </summary>
        /// <value>The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not provided, image must have transparency, which will be used as the mask.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public byte[] Image { get; set; }

        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters.
        /// </summary>
        /// <value>A text description of the desired image(s). The maximum length is 1000 characters.</value>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where &#x60;image&#x60; should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as &#x60;image&#x60;.
        /// </summary>
        /// <value>An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where &#x60;image&#x60; should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions as &#x60;image&#x60;.</value>
        [DataMember(Name="mask", EmitDefaultValue=false)]
        public byte[] Mask { get; set; }

        /// <summary>
        /// The model to use for image generation. Only &#x60;dall-e-2&#x60; is supported at this time.
        /// </summary>
        /// <value>The model to use for image generation. Only &#x60;dall-e-2&#x60; is supported at this time.</value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public AnyOfCreateImageEditRequestModel Model { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 10.
        /// </summary>
        /// <value>The number of images to generate. Must be between 1 and 10.</value>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public int? N { get; set; }



        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids). 
        /// </summary>
        /// <value>A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids). </value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public string User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateImageEditRequest {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Mask: ").Append(Mask).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  ResponseFormat: ").Append(ResponseFormat).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as CreateImageEditRequest);
        }

        /// <summary>
        /// Returns true if CreateImageEditRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateImageEditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateImageEditRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) && 
                (
                    this.Mask == input.Mask ||
                    (this.Mask != null &&
                    this.Mask.Equals(input.Mask))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ResponseFormat == input.ResponseFormat ||
                    (this.ResponseFormat != null &&
                    this.ResponseFormat.Equals(input.ResponseFormat))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Prompt != null)
                    hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.Mask != null)
                    hashCode = hashCode * 59 + this.Mask.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ResponseFormat != null)
                    hashCode = hashCode * 59 + this.ResponseFormat.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
