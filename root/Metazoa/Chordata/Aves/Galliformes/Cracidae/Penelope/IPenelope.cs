namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Penelope;

/// <summary>
/// Interface defining characteristics of Penelope (genus).
/// </summary>
public interface IPenelope
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
