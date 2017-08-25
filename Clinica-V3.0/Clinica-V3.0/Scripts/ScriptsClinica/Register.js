$('#UserRoles').on('change', function () {
    if (this.value.toLowerCase() === "medico") {
        $('#form-group-especializacao').fadeIn();
    } else {
        $('#form-group-especializacao').fadeOut();
    }
});