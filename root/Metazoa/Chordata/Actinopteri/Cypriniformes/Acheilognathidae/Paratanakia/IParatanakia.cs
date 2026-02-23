namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Paratanakia;

/// <summary>
/// Interface defining characteristics of Paratanakia (genus).
/// </summary>
public interface IParatanakia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
