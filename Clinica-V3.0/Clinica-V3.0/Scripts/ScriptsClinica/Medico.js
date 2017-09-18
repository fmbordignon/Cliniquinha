$(document).ready(function () {
    $('#stringNome').autocomplete({
        source: '/Medicos/NomeFilter'
    });

    $('#stringEspecializacao').autocomplete({
        source: '/Medicos/EspecializacaoFilter'
    });
})