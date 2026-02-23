namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Rhodeus;

/// <summary>
/// Interface defining characteristics of Rhodeus (genus).
/// </summary>
public interface IRhodeus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
