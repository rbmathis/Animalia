namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Schilbidae.Siluranodon;

/// <summary>
/// Interface defining characteristics of Siluranodon (genus).
/// </summary>
public interface ISiluranodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
