namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Pseudogyrinocheilus;

/// <summary>
/// Interface defining characteristics of Pseudogyrinocheilus (genus).
/// </summary>
public interface IPseudogyrinocheilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
