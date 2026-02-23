namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Acheilognathus;

/// <summary>
/// Interface defining characteristics of Acheilognathus (genus).
/// </summary>
public interface IAcheilognathus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
