namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Didynamipus;

/// <summary>
/// Interface defining characteristics of Didynamipus (genus).
/// </summary>
public interface IDidynamipus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
