namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Plethodon;

/// <summary>
/// Interface defining characteristics of Plethodon (genus).
/// </summary>
public interface IPlethodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
