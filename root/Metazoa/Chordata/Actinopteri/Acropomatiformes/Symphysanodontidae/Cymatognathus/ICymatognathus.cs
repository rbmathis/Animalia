namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Symphysanodontidae.Cymatognathus;

/// <summary>
/// Interface defining characteristics of Cymatognathus (genus).
/// </summary>
public interface ICymatognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
