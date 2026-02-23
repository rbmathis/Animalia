namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Lachnolaimus;

/// <summary>
/// Interface defining characteristics of Lachnolaimus (genus).
/// </summary>
public interface ILachnolaimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
