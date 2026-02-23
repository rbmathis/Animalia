namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Zaphotias;

/// <summary>
/// Interface defining characteristics of Zaphotias (genus).
/// </summary>
public interface IZaphotias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
