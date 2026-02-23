namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Chelydra;

/// <summary>
/// Interface defining characteristics of Chelydra (genus).
/// </summary>
public interface IChelydra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
