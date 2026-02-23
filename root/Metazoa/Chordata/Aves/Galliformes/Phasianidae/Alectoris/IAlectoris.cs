namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Alectoris;

/// <summary>
/// Interface defining characteristics of Alectoris (genus).
/// </summary>
public interface IAlectoris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
