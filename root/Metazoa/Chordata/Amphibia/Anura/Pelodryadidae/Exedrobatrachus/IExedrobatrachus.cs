namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Exedrobatrachus;

/// <summary>
/// Interface defining characteristics of Exedrobatrachus (genus).
/// </summary>
public interface IExedrobatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
