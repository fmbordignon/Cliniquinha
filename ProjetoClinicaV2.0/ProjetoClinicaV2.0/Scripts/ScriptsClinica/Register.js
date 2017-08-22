$('#UserRoles').on('change', function () {
    if (this.value == "Medico") {
        $('#especilizacao').fadeIn();
    } else {
        $('#especilizacao').fadeOut();
    }
});