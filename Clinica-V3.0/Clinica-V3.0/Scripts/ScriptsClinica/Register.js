$('#UserRoles').on('change', function () {
    if (this.value.toLowerCase() === "medico") {
        $('#form-group-especializacao').fadeIn();
    } else {
        $('#form-group-especializacao').fadeOut();
    }
});




    $(document).ready(function ()   
    {  
        $('#registerFormId').validate({  
            errorClass: 'text-danger', // You can change the animation class for a different entrance animation - check animations page  
            errorElement: 'span',  
            highlight: function (element, errorClass) {
                $(element).removeClass(errorClass);
            }, 
            rules: {  
                'Rg': {  
                    required: true
                },  
      
                'UserRoles': {  
                    required: true
                },  
      
                'Especializacao': {  
                    required: true
                }  
            },  
            messages: {  
                'Rg': {
                    required: 'Please provide a password'  
                 },
                'UserRoles': {  
                    required: 'Please provide a password'  
                }, 
      
                'Especializacao': {  
                    required: 'Please provide a password'
                }  
            }  
        });  
    });   