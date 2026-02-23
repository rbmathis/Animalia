namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Eunectes;

/// <summary>
/// Interface defining characteristics of Eunectes (genus).
/// </summary>
public interface IEunectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
