using System.ComponentModel.DataAnnotations; // import for validation 

using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace ValidationAttributes.Models
{
    public class Student
    {
        // [Required] //this will show default  validation message 
        [Required(ErrorMessage ="Name should not be empty")] // this is custom validation message

        //[StringLength(14)]  //this syntax show that user can input maximum 14 characters in Name input

        // [StringLength(14,MinimumLength =3)]  

        [StringLength(14, MinimumLength = 3,ErrorMessage ="the name field should be between 3 to 14 characters ")] //if you want custom message show then used this syntax
        public string Name { get; set; }
        //==================================================================================================================================
        

        [Required]
        // [StringLength(3)] // maximum length for inputis 3 but this is int so but syntax is string so it give error

        [Range(1,200)] //Range is betweeen 1 to 200
        public int Age  { get; set; }
      
        
//==================================================================================================================================


        [Required]
        // [StringLength(10)] // Nepali phone number is 10 digit so maxmimum length is kept 10 byt it is int but syntax is string type so it give error

        [RegularExpression(@"^(?:\+977[- ]?)?(9[678]\d{8}|0[1-9]\d{6})$",ErrorMessage ="please input valid Nepal Phone Number")] // Nepali phone number is 10 digit .this is most imp validation  which can be used
                                                                           // in many input validation string under  regular expression ()  ,a string  Pattern 
                                                                           //  is used which can be copied from internet 
        public long PhNum { get; set; }

        //=============================================================================================================================================================

        [Required]

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail\.com$",ErrorMessage ="Invalid Gmail")] //For only Gmail
        
        public string Email { get; set; }

        //=====================================================================================================================================

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")] //for strong password


        public string Password { get; set; }

        //=========================================================================================================================================

        [Required]
        [Compare("Password")] // under this compare validation the property like Pssword should be given which we want to compare
        [Display(Name = " Enter The Confirm Password")] //this is for displaying the custom msg for the labels  kept in index.cshtml
        public string  ConfirmPassword { get; set; }


        //============================================================================================================================
        [Required]
        [Url(ErrorMessage ="Invalid URL")] // this validation for url format
        [Display(Name="Enter The Website Url")]
        public string Url { get; set; }

        //=====================================================================================================================================
        //  public Gender gender { get; set; } //just a practice for enum                                                                     

    }


    // public enum Gender // enum is used for constanst like days ,month
    //{
    //    Male,Female
    //} 
}
