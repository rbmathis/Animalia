namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae.Philesturnus;

/// <summary>
/// Interface defining characteristics of Philesturnus (genus).
/// </summary>
public interface IPhilesturnus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
