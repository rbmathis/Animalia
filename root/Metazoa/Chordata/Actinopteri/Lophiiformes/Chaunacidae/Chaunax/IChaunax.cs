namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Chaunacidae.Chaunax;

/// <summary>
/// Interface defining characteristics of Chaunax (genus).
/// </summary>
public interface IChaunax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
