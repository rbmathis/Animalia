namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Amaurornis;

/// <summary>
/// Interface defining characteristics of Amaurornis (genus).
/// </summary>
public interface IAmaurornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
