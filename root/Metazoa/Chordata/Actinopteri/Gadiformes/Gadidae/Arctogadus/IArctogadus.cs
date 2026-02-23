namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Gadidae.Arctogadus;

/// <summary>
/// Interface defining characteristics of Arctogadus (genus).
/// </summary>
public interface IArctogadus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
