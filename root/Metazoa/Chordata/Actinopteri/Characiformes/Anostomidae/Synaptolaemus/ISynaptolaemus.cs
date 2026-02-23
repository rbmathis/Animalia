namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Synaptolaemus;

/// <summary>
/// Interface defining characteristics of Synaptolaemus (genus).
/// </summary>
public interface ISynaptolaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
