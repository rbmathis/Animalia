namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Schetba;

/// <summary>
/// Interface defining characteristics of Schetba (genus).
/// </summary>
public interface ISchetba
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
