$(document).ready(function () {
    Inputmask({ regex: "\^(0[0-9]|1[0-9]|2[0-3]):([0-5][0-9])\$" }).mask("#hora");
                        
    Inputmask({ regex: "\^([0-2][0-9]|3[0-1])\/(0[0-9]|1[0-2])\/(2017)\$" }).mask("#DataConsulta");  

    Inputmask({ regex: "\^\\(([0-5][0-9])\\)(3[0-9]{3})|(9[0-9]{4})\-([0-9]{4})\$" }).mask("#Telefone");
   
    Inputmask({ regex: "\^([0-2][0-9]|3[0-1])\/(0[0-9]|1[0-2])\/{1}[0-9]{4}\$" }).mask("#DataNascimento");
  
    Inputmask({ regex: "\^\[0-9]{10}\$" }).mask("#Rg");

    Inputmask({ regex: "[a-zA-Z\u00C0-\u00FF ]+" }).mask("#Nome");
    $("#Nome, #PlanoDeSaude, #Rg").inputmask({ "placeholder": "" });

});