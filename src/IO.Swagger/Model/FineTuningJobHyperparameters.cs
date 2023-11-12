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
    /// The hyperparameters used for the fine-tuning job. See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
    /// </summary>
    [DataContract]
        public partial class FineTuningJobHyperparameters :  IEquatable<FineTuningJobHyperparameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJobHyperparameters" /> class.
        /// </summary>
        /// <param name="nEpochs">The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset. \&quot;auto\&quot; decides the optimal number of epochs based on the size of the dataset. If setting the number manually, we support any number between 1 and 50 epochs. (required) (default to auto).</param>
        public FineTuningJobHyperparameters(OneOfFineTuningJobHyperparametersNEpochs nEpochs = default)
        {
            // to ensure "nEpochs" is required (not null)
            if (nEpochs == null)
            {
                throw new InvalidDataException("nEpochs is a required property for FineTuningJobHyperparameters and cannot be null");
            }
            else
            {
                this.NEpochs = nEpochs;
            }
        }
        
        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset. \&quot;auto\&quot; decides the optimal number of epochs based on the size of the dataset. If setting the number manually, we support any number between 1 and 50 epochs.
        /// </summary>
        /// <value>The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset. \&quot;auto\&quot; decides the optimal number of epochs based on the size of the dataset. If setting the number manually, we support any number between 1 and 50 epochs.</value>
        [DataMember(Name="n_epochs", EmitDefaultValue=false)]
        public OneOfFineTuningJobHyperparametersNEpochs NEpochs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FineTuningJobHyperparameters {\n");
            sb.Append("  NEpochs: ").Append(NEpochs).Append("\n");
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
            return this.Equals(input as FineTuningJobHyperparameters);
        }

        /// <summary>
        /// Returns true if FineTuningJobHyperparameters instances are equal
        /// </summary>
        /// <param name="input">Instance of FineTuningJobHyperparameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FineTuningJobHyperparameters input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NEpochs == input.NEpochs ||
                    (this.NEpochs != null &&
                    this.NEpochs.Equals(input.NEpochs))
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
                if (this.NEpochs != null)
                    hashCode = hashCode * 59 + this.NEpochs.GetHashCode();
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