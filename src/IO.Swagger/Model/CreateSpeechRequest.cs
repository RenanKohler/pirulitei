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
    /// CreateSpeechRequest
    /// </summary>
    [DataContract]
        public partial class CreateSpeechRequest :  IEquatable<CreateSpeechRequest>, IValidatableObject
    {
        /// <summary>
        /// The voice to use when generating the audio. Supported voices are &#x60;alloy&#x60;, &#x60;echo&#x60;, &#x60;fable&#x60;, &#x60;onyx&#x60;, &#x60;nova&#x60;, and &#x60;shimmer&#x60;.
        /// </summary>
        /// <value>The voice to use when generating the audio. Supported voices are &#x60;alloy&#x60;, &#x60;echo&#x60;, &#x60;fable&#x60;, &#x60;onyx&#x60;, &#x60;nova&#x60;, and &#x60;shimmer&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum VoiceEnum
        {
            /// <summary>
            /// Enum Alloy for value: alloy
            /// </summary>
            [EnumMember(Value = "alloy")]
            Alloy = 1,
            /// <summary>
            /// Enum Echo for value: echo
            /// </summary>
            [EnumMember(Value = "echo")]
            Echo = 2,
            /// <summary>
            /// Enum Fable for value: fable
            /// </summary>
            [EnumMember(Value = "fable")]
            Fable = 3,
            /// <summary>
            /// Enum Onyx for value: onyx
            /// </summary>
            [EnumMember(Value = "onyx")]
            Onyx = 4,
            /// <summary>
            /// Enum Nova for value: nova
            /// </summary>
            [EnumMember(Value = "nova")]
            Nova = 5,
            /// <summary>
            /// Enum Shimmer for value: shimmer
            /// </summary>
            [EnumMember(Value = "shimmer")]
            Shimmer = 6        }
        /// <summary>
        /// The voice to use when generating the audio. Supported voices are &#x60;alloy&#x60;, &#x60;echo&#x60;, &#x60;fable&#x60;, &#x60;onyx&#x60;, &#x60;nova&#x60;, and &#x60;shimmer&#x60;.
        /// </summary>
        /// <value>The voice to use when generating the audio. Supported voices are &#x60;alloy&#x60;, &#x60;echo&#x60;, &#x60;fable&#x60;, &#x60;onyx&#x60;, &#x60;nova&#x60;, and &#x60;shimmer&#x60;.</value>
        [DataMember(Name="voice", EmitDefaultValue=false)]
        public VoiceEnum Voice { get; set; }
        /// <summary>
        /// The format to audio in. Supported formats are &#x60;mp3&#x60;, &#x60;opus&#x60;, &#x60;aac&#x60;, and &#x60;flac&#x60;.
        /// </summary>
        /// <value>The format to audio in. Supported formats are &#x60;mp3&#x60;, &#x60;opus&#x60;, &#x60;aac&#x60;, and &#x60;flac&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ResponseFormatEnum
        {
            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            [EnumMember(Value = "mp3")]
            Mp3 = 1,
            /// <summary>
            /// Enum Opus for value: opus
            /// </summary>
            [EnumMember(Value = "opus")]
            Opus = 2,
            /// <summary>
            /// Enum Aac for value: aac
            /// </summary>
            [EnumMember(Value = "aac")]
            Aac = 3,
            /// <summary>
            /// Enum Flac for value: flac
            /// </summary>
            [EnumMember(Value = "flac")]
            Flac = 4        }
        /// <summary>
        /// The format to audio in. Supported formats are &#x60;mp3&#x60;, &#x60;opus&#x60;, &#x60;aac&#x60;, and &#x60;flac&#x60;.
        /// </summary>
        /// <value>The format to audio in. Supported formats are &#x60;mp3&#x60;, &#x60;opus&#x60;, &#x60;aac&#x60;, and &#x60;flac&#x60;.</value>
        [DataMember(Name="response_format", EmitDefaultValue=false)]
        public ResponseFormatEnum? ResponseFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechRequest" /> class.
        /// </summary>
        /// <param name="model">One of the available [TTS models](/docs/models/tts): &#x60;tts-1&#x60; or &#x60;tts-1-hd&#x60;  (required).</param>
        /// <param name="input">The text to generate audio for. The maximum length is 4096 characters. (required).</param>
        /// <param name="voice">The voice to use when generating the audio. Supported voices are &#x60;alloy&#x60;, &#x60;echo&#x60;, &#x60;fable&#x60;, &#x60;onyx&#x60;, &#x60;nova&#x60;, and &#x60;shimmer&#x60;. (required).</param>
        /// <param name="responseFormat">The format to audio in. Supported formats are &#x60;mp3&#x60;, &#x60;opus&#x60;, &#x60;aac&#x60;, and &#x60;flac&#x60;. (default to ResponseFormatEnum.Mp3).</param>
        /// <param name="speed">The speed of the generated audio. Select a value from &#x60;0.25&#x60; to &#x60;4.0&#x60;. &#x60;1.0&#x60; is the default. (default to 1).</param>
        public CreateSpeechRequest(AnyOfCreateSpeechRequestModel model = default(AnyOfCreateSpeechRequestModel), string input = default(string), VoiceEnum voice = default(VoiceEnum), ResponseFormatEnum? responseFormat = ResponseFormatEnum.Mp3, decimal? speed = 1)
        {
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new InvalidDataException("model is a required property for CreateSpeechRequest and cannot be null");
            }
            else
            {
                this.Model = model;
            }
            // to ensure "input" is required (not null)
            if (input == null)
            {
                throw new InvalidDataException("input is a required property for CreateSpeechRequest and cannot be null");
            }
            else
            {
                this.Input = input;
            }
            // to ensure "voice" is required (not null)
            if (voice == null)
            {
                throw new InvalidDataException("voice is a required property for CreateSpeechRequest and cannot be null");
            }
            else
            {
                this.Voice = voice;
            }
            // use default value if no "responseFormat" provided
            if (responseFormat == null)
            {
                this.ResponseFormat = ResponseFormatEnum.Mp3;
            }
            else
            {
                this.ResponseFormat = responseFormat;
            }
            // use default value if no "speed" provided
            if (speed == null)
            {
                this.Speed = 1;
            }
            else
            {
                this.Speed = speed;
            }
        }
        
        /// <summary>
        /// One of the available [TTS models](/docs/models/tts): &#x60;tts-1&#x60; or &#x60;tts-1-hd&#x60; 
        /// </summary>
        /// <value>One of the available [TTS models](/docs/models/tts): &#x60;tts-1&#x60; or &#x60;tts-1-hd&#x60; </value>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public AnyOfCreateSpeechRequestModel Model { get; set; }

        /// <summary>
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </summary>
        /// <value>The text to generate audio for. The maximum length is 4096 characters.</value>
        [DataMember(Name="input", EmitDefaultValue=false)]
        public string Input { get; set; }



        /// <summary>
        /// The speed of the generated audio. Select a value from &#x60;0.25&#x60; to &#x60;4.0&#x60;. &#x60;1.0&#x60; is the default.
        /// </summary>
        /// <value>The speed of the generated audio. Select a value from &#x60;0.25&#x60; to &#x60;4.0&#x60;. &#x60;1.0&#x60; is the default.</value>
        [DataMember(Name="speed", EmitDefaultValue=false)]
        public decimal? Speed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSpeechRequest {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  Voice: ").Append(Voice).Append("\n");
            sb.Append("  ResponseFormat: ").Append(ResponseFormat).Append("\n");
            sb.Append("  Speed: ").Append(Speed).Append("\n");
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
            return this.Equals(input as CreateSpeechRequest);
        }

        /// <summary>
        /// Returns true if CreateSpeechRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSpeechRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSpeechRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Input == input.Input ||
                    (this.Input != null &&
                    this.Input.Equals(input.Input))
                ) && 
                (
                    this.Voice == input.Voice ||
                    (this.Voice != null &&
                    this.Voice.Equals(input.Voice))
                ) && 
                (
                    this.ResponseFormat == input.ResponseFormat ||
                    (this.ResponseFormat != null &&
                    this.ResponseFormat.Equals(input.ResponseFormat))
                ) && 
                (
                    this.Speed == input.Speed ||
                    (this.Speed != null &&
                    this.Speed.Equals(input.Speed))
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
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Input != null)
                    hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Voice != null)
                    hashCode = hashCode * 59 + this.Voice.GetHashCode();
                if (this.ResponseFormat != null)
                    hashCode = hashCode * 59 + this.ResponseFormat.GetHashCode();
                if (this.Speed != null)
                    hashCode = hashCode * 59 + this.Speed.GetHashCode();
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
