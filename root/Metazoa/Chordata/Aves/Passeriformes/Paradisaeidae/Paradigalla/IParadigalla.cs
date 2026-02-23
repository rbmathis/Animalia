namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Paradigalla;

/// <summary>
/// Interface defining characteristics of Paradigalla (genus).
/// </summary>
public interface IParadigalla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
