namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Plethodontohyla;

/// <summary>
/// Interface defining characteristics of Plethodontohyla (genus).
/// </summary>
public interface IPlethodontohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
