namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Ensatina;

/// <summary>
/// Interface defining characteristics of Ensatina (genus).
/// </summary>
public interface IEnsatina
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
