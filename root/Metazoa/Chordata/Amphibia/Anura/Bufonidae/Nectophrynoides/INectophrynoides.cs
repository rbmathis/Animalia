namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nectophrynoides;

/// <summary>
/// Interface defining characteristics of Nectophrynoides (genus).
/// </summary>
public interface INectophrynoides
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
