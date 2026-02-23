namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Heliornithidae.Heliornis;

/// <summary>
/// Interface defining characteristics of Heliornis (genus).
/// </summary>
public interface IHeliornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
