$(document).ready(function () {
    $('#stringNome').autocomplete({
        source: '/Administradores/NomeFilter'
    });
})