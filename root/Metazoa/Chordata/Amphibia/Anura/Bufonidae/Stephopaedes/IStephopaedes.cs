namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Stephopaedes;

/// <summary>
/// Interface defining characteristics of Stephopaedes (genus).
/// </summary>
public interface IStephopaedes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
