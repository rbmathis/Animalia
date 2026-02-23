namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Ophthalmotilapia;

/// <summary>
/// Interface defining characteristics of Ophthalmotilapia (genus).
/// </summary>
public interface IOphthalmotilapia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
