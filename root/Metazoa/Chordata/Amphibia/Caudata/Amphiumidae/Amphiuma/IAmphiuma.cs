namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Amphiumidae.Amphiuma;

/// <summary>
/// Interface defining characteristics of Amphiuma (genus).
/// </summary>
public interface IAmphiuma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
