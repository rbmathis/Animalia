namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Epidalea;

/// <summary>
/// Interface defining characteristics of Epidalea (genus).
/// </summary>
public interface IEpidalea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
