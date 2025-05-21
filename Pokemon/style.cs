/* Apply a simple Pokémon-themed font and color scheme */
body {
    font-family: 'Verdana', sans-serif;
    background: linear-gradient(to bottom right, #f2d94e, #f28f3b);
    color: #2d2d2d;
    text-align: center;
    padding: 2rem;
    min-height: 100vh;
    margin: 0;
}

/* Pokémon header */
h1 {
    font-size: 2.5rem;
    color: #ef5350; /* Pokémon red */
    text-shadow: 2px 2px #fff176; /* Yellowish outline */
    margin-bottom: 2rem;
}

/* Input and button styling */
#pokemon-search {
    padding: 0.5rem;
    font-size: 1rem;
    border: 2px solid #3b4cca;
    border-radius: 8px;
    width: 200px;
    margin-right: 0.5rem;
}

#pokemon-button {
    padding: 0.5rem 1rem;
    font-size: 1rem;
    background-color: #3b4cca; /* Pokémon blue */
    color: white;
    border: none;
    border-radius: 8px;
    cursor: pointer;
    transition: background 0.3s;
}

#pokemon-button:hover {
    background-color: #2a2aaf;
}

/* Pokémon result display */
#pokemon-name {
    font-size: 1.5rem;
    margin-top: 2rem;
    text-transform: capitalize;
    color: #37474f;
}

#pokemon-image {
    margin-top: 1rem;
    width: 200px;
    height: 200px;
    object-fit: contain;
    border: 4px solid #3b4cca;
    border-radius: 50%;
    background-color: white;
    padding: 1rem;
}
