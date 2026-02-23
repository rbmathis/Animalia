namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Eremnoculus;

/// <summary>
/// Interface defining characteristics of Eremnoculus (genus).
/// </summary>
public interface IEremnoculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
