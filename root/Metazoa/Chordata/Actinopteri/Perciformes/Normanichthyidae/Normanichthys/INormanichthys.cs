namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Normanichthyidae.Normanichthys;

/// <summary>
/// Interface defining characteristics of Normanichthys (genus).
/// </summary>
public interface INormanichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
