/* 
 * API Marketplace Grupo Netshoes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// Body1
    /// </summary>
    [DataContract]
    public partial class Body1 :  IEquatable<Body1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Body1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Body1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Body1" /> class.
        /// </summary>
        /// <param name="Sku">Sku (required).</param>
        /// <param name="ProductGroup">ProductGroup (required).</param>
        /// <param name="Department">Department (required).</param>
        /// <param name="ProductType">ProductType (required).</param>
        /// <param name="Brand">Brand (required).</param>
        /// <param name="Name">Name (required).</param>
        /// <param name="Description">Description (required).</param>
        /// <param name="Color">Color (required).</param>
        /// <param name="Flavor">Flavor (required).</param>
        /// <param name="Gender">Gender (required).</param>
        /// <param name="ManufacturerCode">ManufacturerCode.</param>
        /// <param name="Size">Size (required).</param>
        /// <param name="EanIsbn">EanIsbn.</param>
        /// <param name="Height">Height (required).</param>
        /// <param name="Width">Width (required).</param>
        /// <param name="Depth">Depth (required).</param>
        /// <param name="Weight">Weight (required).</param>
        /// <param name="Video">Video.</param>
        /// <param name="Images">Images (required).</param>
        /// <param name="Attributes">Attributes.</param>
        public Body1(string Sku = default(string), string ProductGroup = default(string), string Department = default(string), string ProductType = default(string), string Brand = default(string), string Name = default(string), string Description = default(string), string Color = default(string), string Flavor = default(string), string Gender = default(string), string ManufacturerCode = default(string), string Size = default(string), string EanIsbn = default(string), double? Height = default(double?), double? Width = default(double?), double? Depth = default(double?), double? Weight = default(double?), string Video = default(string), List<ProductsImages> Images = default(List<ProductsImages>), List<ProductsAttributes> Attributes = default(List<ProductsAttributes>))
        {
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "ProductGroup" is required (not null)
            if (ProductGroup == null)
            {
                throw new InvalidDataException("ProductGroup is a required property for Body1 and cannot be null");
            }
            else
            {
                this.ProductGroup = ProductGroup;
            }
            // to ensure "Department" is required (not null)
            if (Department == null)
            {
                throw new InvalidDataException("Department is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Department = Department;
            }
            // to ensure "ProductType" is required (not null)
            if (ProductType == null)
            {
                throw new InvalidDataException("ProductType is a required property for Body1 and cannot be null");
            }
            else
            {
                this.ProductType = ProductType;
            }
            // to ensure "Brand" is required (not null)
            if (Brand == null)
            {
                throw new InvalidDataException("Brand is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Brand = Brand;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Description" is required (not null)
            if (Description == null)
            {
                throw new InvalidDataException("Description is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Description = Description;
            }
            // to ensure "Color" is required (not null)
            if (Color == null)
            {
                throw new InvalidDataException("Color is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Color = Color;
            }
            // to ensure "Flavor" is required (not null)
            if (Flavor == null)
            {
                throw new InvalidDataException("Flavor is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Flavor = Flavor;
            }
            // to ensure "Gender" is required (not null)
            if (Gender == null)
            {
                throw new InvalidDataException("Gender is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Gender = Gender;
            }
            // to ensure "Size" is required (not null)
            if (Size == null)
            {
                throw new InvalidDataException("Size is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Size = Size;
            }
            // to ensure "Height" is required (not null)
            if (Height == null)
            {
                throw new InvalidDataException("Height is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Height = Height;
            }
            // to ensure "Width" is required (not null)
            if (Width == null)
            {
                throw new InvalidDataException("Width is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Width = Width;
            }
            // to ensure "Depth" is required (not null)
            if (Depth == null)
            {
                throw new InvalidDataException("Depth is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Depth = Depth;
            }
            // to ensure "Weight" is required (not null)
            if (Weight == null)
            {
                throw new InvalidDataException("Weight is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Weight = Weight;
            }
            // to ensure "Images" is required (not null)
            if (Images == null)
            {
                throw new InvalidDataException("Images is a required property for Body1 and cannot be null");
            }
            else
            {
                this.Images = Images;
            }
            this.ManufacturerCode = ManufacturerCode;
            this.EanIsbn = EanIsbn;
            this.Video = Video;
            this.Attributes = Attributes;
        }
        
        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// Gets or Sets ProductGroup
        /// </summary>
        [DataMember(Name="productGroup", EmitDefaultValue=false)]
        public string ProductGroup { get; set; }
        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }
        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public string ProductType { get; set; }
        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public string Color { get; set; }
        /// <summary>
        /// Gets or Sets Flavor
        /// </summary>
        [DataMember(Name="flavor", EmitDefaultValue=false)]
        public string Flavor { get; set; }
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// Gets or Sets ManufacturerCode
        /// </summary>
        [DataMember(Name="manufacturerCode", EmitDefaultValue=false)]
        public string ManufacturerCode { get; set; }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }
        /// <summary>
        /// Gets or Sets EanIsbn
        /// </summary>
        [DataMember(Name="eanIsbn", EmitDefaultValue=false)]
        public string EanIsbn { get; set; }
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }
        /// <summary>
        /// Gets or Sets Depth
        /// </summary>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public double? Depth { get; set; }
        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public double? Weight { get; set; }
        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name="video", EmitDefaultValue=false)]
        public string Video { get; set; }
        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<ProductsImages> Images { get; set; }
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ProductsAttributes> Attributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Body1 {\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  ProductGroup: ").Append(ProductGroup).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Flavor: ").Append(Flavor).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  ManufacturerCode: ").Append(ManufacturerCode).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  EanIsbn: ").Append(EanIsbn).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Body1);
        }

        /// <summary>
        /// Returns true if Body1 instances are equal
        /// </summary>
        /// <param name="other">Instance of Body1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Body1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.ProductGroup == other.ProductGroup ||
                    this.ProductGroup != null &&
                    this.ProductGroup.Equals(other.ProductGroup)
                ) && 
                (
                    this.Department == other.Department ||
                    this.Department != null &&
                    this.Department.Equals(other.Department)
                ) && 
                (
                    this.ProductType == other.ProductType ||
                    this.ProductType != null &&
                    this.ProductType.Equals(other.ProductType)
                ) && 
                (
                    this.Brand == other.Brand ||
                    this.Brand != null &&
                    this.Brand.Equals(other.Brand)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Flavor == other.Flavor ||
                    this.Flavor != null &&
                    this.Flavor.Equals(other.Flavor)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.ManufacturerCode == other.ManufacturerCode ||
                    this.ManufacturerCode != null &&
                    this.ManufacturerCode.Equals(other.ManufacturerCode)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.EanIsbn == other.EanIsbn ||
                    this.EanIsbn != null &&
                    this.EanIsbn.Equals(other.EanIsbn)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.Depth == other.Depth ||
                    this.Depth != null &&
                    this.Depth.Equals(other.Depth)
                ) && 
                (
                    this.Weight == other.Weight ||
                    this.Weight != null &&
                    this.Weight.Equals(other.Weight)
                ) && 
                (
                    this.Video == other.Video ||
                    this.Video != null &&
                    this.Video.Equals(other.Video)
                ) && 
                (
                    this.Images == other.Images ||
                    this.Images != null &&
                    this.Images.SequenceEqual(other.Images)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.ProductGroup != null)
                    hash = hash * 59 + this.ProductGroup.GetHashCode();
                if (this.Department != null)
                    hash = hash * 59 + this.Department.GetHashCode();
                if (this.ProductType != null)
                    hash = hash * 59 + this.ProductType.GetHashCode();
                if (this.Brand != null)
                    hash = hash * 59 + this.Brand.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Flavor != null)
                    hash = hash * 59 + this.Flavor.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.ManufacturerCode != null)
                    hash = hash * 59 + this.ManufacturerCode.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.EanIsbn != null)
                    hash = hash * 59 + this.EanIsbn.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.Depth != null)
                    hash = hash * 59 + this.Depth.GetHashCode();
                if (this.Weight != null)
                    hash = hash * 59 + this.Weight.GetHashCode();
                if (this.Video != null)
                    hash = hash * 59 + this.Video.GetHashCode();
                if (this.Images != null)
                    hash = hash * 59 + this.Images.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Sku (string) maxLength
            if(this.Sku != null && this.Sku.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Sku, length must be less than 50.", new [] { "Sku" });
            }

            // Sku (string) minLength
            if(this.Sku != null && this.Sku.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Sku, length must be greater than 1.", new [] { "Sku" });
            }

            // ProductGroup (string) maxLength
            if(this.ProductGroup != null && this.ProductGroup.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ProductGroup, length must be less than 50.", new [] { "ProductGroup" });
            }

            // ProductGroup (string) minLength
            if(this.ProductGroup != null && this.ProductGroup.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ProductGroup, length must be greater than 1.", new [] { "ProductGroup" });
            }

            // Department (string) maxLength
            if(this.Department != null && this.Department.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Department, length must be less than 50.", new [] { "Department" });
            }

            // Department (string) minLength
            if(this.Department != null && this.Department.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Department, length must be greater than 1.", new [] { "Department" });
            }

            // ProductType (string) maxLength
            if(this.ProductType != null && this.ProductType.Length > 50)
            {
                yield return new ValidationResult("Invalid value for ProductType, length must be less than 50.", new [] { "ProductType" });
            }

            // ProductType (string) minLength
            if(this.ProductType != null && this.ProductType.Length < 1)
            {
                yield return new ValidationResult("Invalid value for ProductType, length must be greater than 1.", new [] { "ProductType" });
            }

            // Brand (string) maxLength
            if(this.Brand != null && this.Brand.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Brand, length must be less than 50.", new [] { "Brand" });
            }

            // Brand (string) minLength
            if(this.Brand != null && this.Brand.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Brand, length must be greater than 1.", new [] { "Brand" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 50.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 1.", new [] { "Description" });
            }

            // Gender (string) maxLength
            if(this.Gender != null && this.Gender.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Gender, length must be less than 50.", new [] { "Gender" });
            }

            // Gender (string) minLength
            if(this.Gender != null && this.Gender.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Gender, length must be greater than 1.", new [] { "Gender" });
            }

            // Gender (string) pattern
            Regex regexGender = new Regex(@"Homem|Mulher|Unissex", RegexOptions.CultureInvariant);
            if (false == regexGender.Match(this.Gender).Success)
            {
                yield return new ValidationResult("Invalid value for Gender, must match a pattern of /Homem|Mulher|Unissex/.", new [] { "Gender" });
            }

            // Size (string) maxLength
            if(this.Size != null && this.Size.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Size, length must be less than 50.", new [] { "Size" });
            }

            // Size (string) minLength
            if(this.Size != null && this.Size.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Size, length must be greater than 1.", new [] { "Size" });
            }

            yield break;
        }
    }

}
