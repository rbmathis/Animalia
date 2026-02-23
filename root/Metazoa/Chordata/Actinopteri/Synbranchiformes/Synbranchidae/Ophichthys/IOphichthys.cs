namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Ophichthys;

/// <summary>
/// Interface defining characteristics of Ophichthys (genus).
/// </summary>
public interface IOphichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
