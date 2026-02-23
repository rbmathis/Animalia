namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Lerwa;

/// <summary>
/// Interface defining characteristics of Lerwa (genus).
/// </summary>
public interface ILerwa
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
