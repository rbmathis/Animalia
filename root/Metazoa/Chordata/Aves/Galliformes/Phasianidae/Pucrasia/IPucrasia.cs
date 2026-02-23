namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Pucrasia;

/// <summary>
/// Interface defining characteristics of Pucrasia (genus).
/// </summary>
public interface IPucrasia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
