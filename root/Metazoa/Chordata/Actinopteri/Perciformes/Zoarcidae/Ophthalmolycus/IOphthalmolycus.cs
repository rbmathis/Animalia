namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Ophthalmolycus;

/// <summary>
/// Interface defining characteristics of Ophthalmolycus (genus).
/// </summary>
public interface IOphthalmolycus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
