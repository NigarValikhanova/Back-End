
var carModels = {
    toyota: ['Auris', 'Avalon', 'Camry', 'Corolla', 'Rav4', 'Harrier'],
    ford: ['Cargo', 'Contour', 'Fusion', 'Escape', 'Fiesta', 'Mustang'],
    chevrolet: ['Impala67', 'Malibu', 'Lumina', 'Nexia', 'Onix', 'Tahoe'],
    mercedes: ['A140', 'B150', 'C180', 'E200', 'G400', 'E350'],
    fiat: ['Albea', 'Coupe', 'Doblo', 'Tempra', 'Linea', 'Ulysse']
};

function updateCarModels() {
    var carMarkaSelect = document.getElementById('Marka');
    var carModelSelect = document.getElementById('Model');
    var selectedCarMarka = carMarkaSelect.value;

    carModelSelect.innerHTML = '';

    carModels[selectedCarMarka].forEach(model => {
        var option = document.createElement('option');
        option.value = model;
        option.text = model;
        carModelSelect.add(option);
    });
}
updateCarModels();