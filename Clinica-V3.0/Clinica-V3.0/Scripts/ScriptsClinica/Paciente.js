$(document).ready(function () {
    $('#stringNome').autocomplete({
        source: '/Pacientes/NomeFilter'
    });

    $('#stringTelefone').autocomplete({
        source: '/Pacientes/TelefoneFilter'
    });
})
