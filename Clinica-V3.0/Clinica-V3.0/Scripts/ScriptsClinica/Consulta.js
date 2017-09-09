$(document).ready(function () {
    $('#stringPaciente').autocomplete({
        source: '/Consultas/PacienteFilter'
    });

    $('#stringMedico').autocomplete({
        source: '/Consultas/MedicoFilter'
    });

    $('#stringPlanoSaude').autocomplete({
        source: '/Consultas/PlanoSaudeFilter'
    });
})
