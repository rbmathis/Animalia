namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Perdicula;

/// <summary>
/// Interface defining characteristics of Perdicula (genus).
/// </summary>
public interface IPerdicula
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
