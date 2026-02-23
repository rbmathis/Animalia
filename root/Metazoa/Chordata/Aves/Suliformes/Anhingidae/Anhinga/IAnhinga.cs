namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Suliformes.Anhingidae.Anhinga;

/// <summary>
/// Interface defining characteristics of Anhinga (genus).
/// </summary>
public interface IAnhinga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
