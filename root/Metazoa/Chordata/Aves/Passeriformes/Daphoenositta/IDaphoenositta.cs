namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Daphoenositta;

/// <summary>
/// Interface defining characteristics of Daphoenositta (genus).
/// </summary>
public interface IDaphoenositta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
