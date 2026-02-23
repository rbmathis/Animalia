namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Xanthophryne;

/// <summary>
/// Interface defining characteristics of Xanthophryne (genus).
/// </summary>
public interface IXanthophryne
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
