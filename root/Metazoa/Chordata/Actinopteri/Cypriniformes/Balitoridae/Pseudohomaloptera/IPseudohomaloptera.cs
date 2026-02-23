namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Balitoridae.Pseudohomaloptera;

/// <summary>
/// Interface defining characteristics of Pseudohomaloptera (genus).
/// </summary>
public interface IPseudohomaloptera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
