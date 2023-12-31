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
    /// CreateFileRequest
    /// </summary>
    [DataContract]
        public partial class CreateFileRequest :  IEquatable<CreateFileRequest>, IValidatableObject
    {
        /// <summary>
        /// The intended purpose of the uploaded file.  Use \&quot;fine-tune\&quot; for [Fine-tuning](/docs/api-reference/fine-tuning) and \&quot;assistants\&quot; for [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This allows us to validate the format of the uploaded file is correct for fine-tuning. 
        /// </summary>
        /// <value>The intended purpose of the uploaded file.  Use \&quot;fine-tune\&quot; for [Fine-tuning](/docs/api-reference/fine-tuning) and \&quot;assistants\&quot; for [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This allows us to validate the format of the uploaded file is correct for fine-tuning. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PurposeEnum
        {
            /// <summary>
            /// Enum FineTune for value: fine-tune
            /// </summary>
            [EnumMember(Value = "fine-tune")]
            FineTune = 1,
            /// <summary>
            /// Enum Assistants for value: assistants
            /// </summary>
            [EnumMember(Value = "assistants")]
            Assistants = 2        }
        /// <summary>
        /// The intended purpose of the uploaded file.  Use \&quot;fine-tune\&quot; for [Fine-tuning](/docs/api-reference/fine-tuning) and \&quot;assistants\&quot; for [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This allows us to validate the format of the uploaded file is correct for fine-tuning. 
        /// </summary>
        /// <value>The intended purpose of the uploaded file.  Use \&quot;fine-tune\&quot; for [Fine-tuning](/docs/api-reference/fine-tuning) and \&quot;assistants\&quot; for [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This allows us to validate the format of the uploaded file is correct for fine-tuning. </value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public PurposeEnum Purpose { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileRequest" /> class.
        /// </summary>
        /// <param name="file">The File object (not file name) to be uploaded.  (required).</param>
        /// <param name="purpose">The intended purpose of the uploaded file.  Use \&quot;fine-tune\&quot; for [Fine-tuning](/docs/api-reference/fine-tuning) and \&quot;assistants\&quot; for [Assistants](/docs/api-reference/assistants) and [Messages](/docs/api-reference/messages). This allows us to validate the format of the uploaded file is correct for fine-tuning.  (required).</param>
        public CreateFileRequest(byte[] file = default(byte[]), PurposeEnum purpose = default(PurposeEnum))
        {
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new InvalidDataException("file is a required property for CreateFileRequest and cannot be null");
            }
            else
            {
                this.File = file;
            }
            // to ensure "purpose" is required (not null)
            if (purpose == null)
            {
                throw new InvalidDataException("purpose is a required property for CreateFileRequest and cannot be null");
            }
            else
            {
                this.Purpose = purpose;
            }
        }
        
        /// <summary>
        /// The File object (not file name) to be uploaded. 
        /// </summary>
        /// <value>The File object (not file name) to be uploaded. </value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public byte[] File { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFileRequest {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
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
            return this.Equals(input as CreateFileRequest);
        }

        /// <summary>
        /// Returns true if CreateFileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFileRequest input)
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
                    this.Purpose == input.Purpose ||
                    (this.Purpose != null &&
                    this.Purpose.Equals(input.Purpose))
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
                if (this.Purpose != null)
                    hashCode = hashCode * 59 + this.Purpose.GetHashCode();
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
