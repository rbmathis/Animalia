namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Rhyacichthyidae.Rhyacichthys;

/// <summary>
/// Interface defining characteristics of Rhyacichthys (genus).
/// </summary>
public interface IRhyacichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
