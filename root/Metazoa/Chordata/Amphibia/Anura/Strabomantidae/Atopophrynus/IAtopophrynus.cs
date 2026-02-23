namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Atopophrynus;

/// <summary>
/// Interface defining characteristics of Atopophrynus (genus).
/// </summary>
public interface IAtopophrynus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
