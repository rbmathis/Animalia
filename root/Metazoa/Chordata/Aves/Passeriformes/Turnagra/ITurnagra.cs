namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turnagra;

/// <summary>
/// Interface defining characteristics of Turnagra (genus).
/// </summary>
public interface ITurnagra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
