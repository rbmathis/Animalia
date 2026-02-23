namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Hoplunnis;

/// <summary>
/// Interface defining characteristics of Hoplunnis (genus).
/// </summary>
public interface IHoplunnis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
