namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gonorynchiformes.Kneriidae.Kneria;

/// <summary>
/// Interface defining characteristics of Kneria (genus).
/// </summary>
public interface IKneria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
