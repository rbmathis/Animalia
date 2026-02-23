namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Hypoptychidae.Hypoptychus;

/// <summary>
/// Interface defining characteristics of Hypoptychus (genus).
/// </summary>
public interface IHypoptychus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
