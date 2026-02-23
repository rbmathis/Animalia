namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Chaunacidae.Chaunacops;

/// <summary>
/// Interface defining characteristics of Chaunacops (genus).
/// </summary>
public interface IChaunacops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
