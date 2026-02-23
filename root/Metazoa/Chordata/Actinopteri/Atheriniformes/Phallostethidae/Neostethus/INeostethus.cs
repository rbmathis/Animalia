namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae.Neostethus;

/// <summary>
/// Interface defining characteristics of Neostethus (genus).
/// </summary>
public interface INeostethus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
