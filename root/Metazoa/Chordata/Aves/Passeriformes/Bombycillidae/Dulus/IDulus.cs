namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bombycillidae.Dulus;

/// <summary>
/// Interface defining characteristics of Dulus (genus).
/// </summary>
public interface IDulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
