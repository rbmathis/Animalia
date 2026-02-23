namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Ctenoblepharys;

/// <summary>
/// Interface defining characteristics of Ctenoblepharys (genus).
/// </summary>
public interface ICtenoblepharys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
