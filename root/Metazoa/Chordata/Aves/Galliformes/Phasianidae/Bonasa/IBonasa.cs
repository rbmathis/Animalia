namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Bonasa;

/// <summary>
/// Interface defining characteristics of Bonasa (genus).
/// </summary>
public interface IBonasa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
