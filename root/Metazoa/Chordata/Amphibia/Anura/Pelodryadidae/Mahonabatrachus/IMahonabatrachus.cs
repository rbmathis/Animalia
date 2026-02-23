namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Mahonabatrachus;

/// <summary>
/// Interface defining characteristics of Mahonabatrachus (genus).
/// </summary>
public interface IMahonabatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
