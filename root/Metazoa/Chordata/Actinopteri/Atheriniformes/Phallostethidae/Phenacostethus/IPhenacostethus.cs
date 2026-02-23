namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae.Phenacostethus;

/// <summary>
/// Interface defining characteristics of Phenacostethus (genus).
/// </summary>
public interface IPhenacostethus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
