namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coliiformes.Coliidae.Urocolius;

/// <summary>
/// Interface defining characteristics of Urocolius (genus).
/// </summary>
public interface IUrocolius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
