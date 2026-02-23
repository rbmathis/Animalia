namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Pelobatrachus;

/// <summary>
/// Interface defining characteristics of Pelobatrachus (genus).
/// </summary>
public interface IPelobatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
