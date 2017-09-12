$(document).ready(function () {
    $('#stringNome').autocomplete({
        source: '/Medicos/NomeFilter'
    });
})