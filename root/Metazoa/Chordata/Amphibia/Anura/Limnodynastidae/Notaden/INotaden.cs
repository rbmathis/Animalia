namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Limnodynastidae.Notaden;

/// <summary>
/// Interface defining characteristics of Notaden (genus).
/// </summary>
public interface INotaden
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
