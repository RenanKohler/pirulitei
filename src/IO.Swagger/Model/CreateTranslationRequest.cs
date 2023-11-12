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
    /// CreateTranslationRequest
    /// </summary>
    [DataContract]
        public partial class CreateTranslationRequest :  IEquatable<CreateTranslationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranslationRequest" /> class.
        /// </summary>
        /// <param name="file">The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.  (required).</param>
        /// <param name="model">ID of the model to use. Only &#x60;whisper-1&#x60; is currently available.  (required).</param>
        /// <param name="prompt">An optional text to guide the model&#x27;s style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text/prompting) should be in English. .</param>
        /// <param name="responseFormat">The format of the transcript output, in one of these options: &#x60;json&#x60;, &#x60;text&#x60;, &#x60;srt&#x60;, &#x60;verbose_json&#x60;, or &#x60;vtt&#x60;.  (default to &quot;json&quot;).</param>
        /// <param name="temperature">The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.  (default to 0).</param>
        public CreateTranslationRequest(byte[] file = default(byte[]), AnyOfCreateTranslationRequestModel model = default(AnyOfCreateTranslationRequestModel), string prompt = default(string), string responseFormat = "json", decimal? temperature = 0)
        {
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new InvalidDataException("file is a required property for CreateTranslationRequest and cannot be null");
            }
            else
            {
                this.File = file;
            }
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for CreateTranslationRequest and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            this.Prompt = prompt;
            // use default value if no "responseFormat" provided
            if (responseFormat == null)
            {
                this.ResponseFormat = "json";
            }
            else
            {
                this.ResponseFormat = responseFormat;
            }
            // use default value if no "temperature" provided
            if (temperature == null)
            {
                this.Temperature = 0;
            }
            else
            {
                this.Temperature = temperature;
            }
        }
        
        /// <summary>
        /// The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm. 
        /// </summary>
        /// <value>The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm. </value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public byte[] File { get; set; }

        /// <summary>
        /// ID of the model to use. Only &#x60;whisper-1&#x60; is currently available. 
        /// </summary>
        /// <value>ID of the model to use. Only &#x60;whisper-1&#x60; is currently available. </value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public AnyOfCreateTranslationRequestModel Model { get; set; }

        /// <summary>
        /// An optional text to guide the model&#x27;s style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text/prompting) should be in English. 
        /// </summary>
        /// <value>An optional text to guide the model&#x27;s style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text/prompting) should be in English. </value>
        [DataMember(Name="prompt", EmitDefaultValue=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// The format of the transcript output, in one of these options: &#x60;json&#x60;, &#x60;text&#x60;, &#x60;srt&#x60;, &#x60;verbose_json&#x60;, or &#x60;vtt&#x60;. 
        /// </summary>
        /// <value>The format of the transcript output, in one of these options: &#x60;json&#x60;, &#x60;text&#x60;, &#x60;srt&#x60;, &#x60;verbose_json&#x60;, or &#x60;vtt&#x60;. </value>
        [DataMember(Name="response_format", EmitDefaultValue=false)]
        public string ResponseFormat { get; set; }

        /// <summary>
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit. 
        /// </summary>
        /// <value>The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit. </value>
        [DataMember(Name="temperature", EmitDefaultValue=false)]
        public decimal? Temperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTranslationRequest {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  ResponseFormat: ").Append(ResponseFormat).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
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
            return this.Equals(input as CreateTranslationRequest);
        }

        /// <summary>
        /// Returns true if CreateTranslationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTranslationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTranslationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Prompt == input.Prompt ||
                    (this.Prompt != null &&
                    this.Prompt.Equals(input.Prompt))
                ) && 
                (
                    this.ResponseFormat == input.ResponseFormat ||
                    (this.ResponseFormat != null &&
                    this.ResponseFormat.Equals(input.ResponseFormat))
                ) && 
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                    this.Temperature.Equals(input.Temperature))
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
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Prompt != null)
                    hashCode = hashCode * 59 + this.Prompt.GetHashCode();
                if (this.ResponseFormat != null)
                    hashCode = hashCode * 59 + this.ResponseFormat.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
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
