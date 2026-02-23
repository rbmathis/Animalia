namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Clinotarsus;

/// <summary>
/// Interface defining characteristics of Clinotarsus (genus).
/// </summary>
public interface IClinotarsus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
