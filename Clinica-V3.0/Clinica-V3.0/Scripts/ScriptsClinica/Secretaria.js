$(document).ready(function () {
    $('#stringNome').autocomplete({
        source: '/Secretarias/NomeFilter'
    });
})