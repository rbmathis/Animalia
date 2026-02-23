namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Beduka;

/// <summary>
/// Interface defining characteristics of Beduka (genus).
/// </summary>
public interface IBeduka
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
