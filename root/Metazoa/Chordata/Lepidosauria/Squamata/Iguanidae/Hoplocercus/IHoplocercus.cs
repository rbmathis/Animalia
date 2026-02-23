namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Hoplocercus;

/// <summary>
/// Interface defining characteristics of Hoplocercus (genus).
/// </summary>
public interface IHoplocercus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
