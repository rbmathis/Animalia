namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Afronatrix;

/// <summary>
/// Interface defining characteristics of Afronatrix (genus).
/// </summary>
public interface IAfronatrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
