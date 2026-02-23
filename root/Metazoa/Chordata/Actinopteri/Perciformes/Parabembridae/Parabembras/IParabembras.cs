namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Parabembridae.Parabembras;

/// <summary>
/// Interface defining characteristics of Parabembras (genus).
/// </summary>
public interface IParabembras
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
