namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Pseudocordylus;

/// <summary>
/// Interface defining characteristics of Pseudocordylus (genus).
/// </summary>
public interface IPseudocordylus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
