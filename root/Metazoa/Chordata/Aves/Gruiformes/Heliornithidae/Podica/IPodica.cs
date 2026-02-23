namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae.Podica;

/// <summary>
/// Interface defining characteristics of Podica (genus).
/// </summary>
public interface IPodica
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
