namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Ischnohyla;

/// <summary>
/// Interface defining characteristics of Ischnohyla (genus).
/// </summary>
public interface IIschnohyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
