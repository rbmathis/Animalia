namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Merlucciidae.Lyconus;

/// <summary>
/// Interface defining characteristics of Lyconus (genus).
/// </summary>
public interface ILyconus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
