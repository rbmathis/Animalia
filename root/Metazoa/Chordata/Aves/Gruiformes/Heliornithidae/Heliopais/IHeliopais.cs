namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae.Heliopais;

/// <summary>
/// Interface defining characteristics of Heliopais (genus).
/// </summary>
public interface IHeliopais
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
