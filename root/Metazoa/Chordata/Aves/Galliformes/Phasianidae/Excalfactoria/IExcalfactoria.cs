namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Excalfactoria;

/// <summary>
/// Interface defining characteristics of Excalfactoria (genus).
/// </summary>
public interface IExcalfactoria
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
