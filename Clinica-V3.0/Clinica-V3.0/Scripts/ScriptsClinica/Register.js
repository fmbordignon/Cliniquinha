$('#UserRoles').on('change', function () {
    if (this.value.toLowerCase() === "medico") {
        $('#form-group-especializacao').fadeIn();
    } else {
        $('#form-group-especializacao').fadeOut();
        $('#Especializacao').val('');
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
                    required: {
                        depends: function () {
                            return ($("#UserRoles").val() == "Medico");
                        }
                    }
                },

                'Nome': {
                    required:true
                },

                'Telefone': {
                    required:true
                },

                'Endereco': {
                    required: true
                },

                'Email': {
                    required: true,
                    email: true,
                    remote: '/Account/UserAlreadyExistsAsync'
                                         
                },

                'Password': {
                    required: true,
                    minlength: 6
                },

                 'ConfirmPassword': {
                    required: true,
                    equalTo: "#Password"
                }

            },  
            messages: {  
                'Rg': {
                    required: 'O campo Rg é obrigatório.'  
                 },
                'UserRoles': {  
                    required: 'O campo Tipo de Usuário é obrigatório.'  
                }, 
      
                'Especializacao': {  
                    required: 'O campo Especialização é obrigatório.'
                },

                'Nome': {
                    required: 'O campo Nome é obrigatório.'
                },

                'Telefone': {
                    required: 'O campo Telefone/ Celular é obrigatório.'
                },

                'Endereco': {
                    required: 'O campo Endereço é obrigatório.'

                },

                'Email': {
                    required: 'O campo Email é obrigatório.',
                    email: 'O campo Email não é um endereço de email válido.',
                    remote: 'Email já cadastrado.'
                },

                'Password': {
                    required: 'O campo Senha é obrigatório.',
                    minlength: 'A Senha deve ter no mínimo 6 caracteres.'
                },
                 'ConfirmPassword': {
                     required: 'O campo Confirmar Senha é obrigatório.',
                    equalTo: 'As senhas devem ser iguais.'
                }


            }  
        });  
    });   