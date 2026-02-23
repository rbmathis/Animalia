namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Taractichthys;

/// <summary>
/// Interface defining characteristics of Taractichthys (genus).
/// </summary>
public interface ITaractichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
