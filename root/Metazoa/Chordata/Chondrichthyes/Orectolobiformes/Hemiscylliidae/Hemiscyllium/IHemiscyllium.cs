namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Hemiscylliidae.Hemiscyllium;

/// <summary>
/// Interface defining characteristics of Hemiscyllium (genus).
/// </summary>
public interface IHemiscyllium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
