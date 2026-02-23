namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Tropidolaemus;

/// <summary>
/// Interface defining characteristics of Tropidolaemus (genus).
/// </summary>
public interface ITropidolaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
