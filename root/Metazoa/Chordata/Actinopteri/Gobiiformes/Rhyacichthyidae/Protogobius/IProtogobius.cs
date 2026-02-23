namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Rhyacichthyidae.Protogobius;

/// <summary>
/// Interface defining characteristics of Protogobius (genus).
/// </summary>
public interface IProtogobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
