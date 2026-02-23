namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Polysticta;

/// <summary>
/// Interface defining characteristics of Polysticta (genus).
/// </summary>
public interface IPolysticta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
