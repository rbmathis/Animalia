namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pseudochondrostoma;

/// <summary>
/// Interface defining characteristics of Pseudochondrostoma (genus).
/// </summary>
public interface IPseudochondrostoma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
