

document.getElementById('pokemon-button').addEventListener('click', function () {
    let searchField = document.getElementById('pokemon-search');
    let pokemonName = searchField.value;

    fetch('https://pokeapi.co/api/v2/pokemon/' + pokemonName)

        .then(res => res.json())

        .then(function (data) {

            document.getElementById('pokemon-name').innerHTML = data.name;
            document.getElementById('pokemon-image').src = data.sprites.versions ['generation-v']['black-white'].animated.front_default;

        })
    searchField.value = '';
})
