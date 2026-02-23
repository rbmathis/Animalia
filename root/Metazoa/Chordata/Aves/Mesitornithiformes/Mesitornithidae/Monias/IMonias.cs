namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Mesitornithiformes.Mesitornithidae.Monias;

/// <summary>
/// Interface defining characteristics of Monias (genus).
/// </summary>
public interface IMonias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
