namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermidae.Paraxenodermus;

/// <summary>
/// Interface defining characteristics of Paraxenodermus (genus).
/// </summary>
public interface IParaxenodermus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
