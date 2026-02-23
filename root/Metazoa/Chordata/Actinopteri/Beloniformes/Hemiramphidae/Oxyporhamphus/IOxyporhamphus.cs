namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Hemiramphidae.Oxyporhamphus;

/// <summary>
/// Interface defining characteristics of Oxyporhamphus (genus).
/// </summary>
public interface IOxyporhamphus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
