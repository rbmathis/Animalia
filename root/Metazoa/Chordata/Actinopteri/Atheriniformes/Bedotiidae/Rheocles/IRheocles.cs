namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Bedotiidae.Rheocles;

/// <summary>
/// Interface defining characteristics of Rheocles (genus).
/// </summary>
public interface IRheocles
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
