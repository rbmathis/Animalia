namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Xiphister;

/// <summary>
/// Interface defining characteristics of Xiphister (genus).
/// </summary>
public interface IXiphister
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
