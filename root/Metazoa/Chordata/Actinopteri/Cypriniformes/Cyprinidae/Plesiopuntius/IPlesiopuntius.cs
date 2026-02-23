namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Plesiopuntius;

/// <summary>
/// Interface defining characteristics of Plesiopuntius (genus).
/// </summary>
public interface IPlesiopuntius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
