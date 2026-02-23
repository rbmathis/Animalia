namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Malapteruridae.Paradoxoglanis;

/// <summary>
/// Interface defining characteristics of Paradoxoglanis (genus).
/// </summary>
public interface IParadoxoglanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
