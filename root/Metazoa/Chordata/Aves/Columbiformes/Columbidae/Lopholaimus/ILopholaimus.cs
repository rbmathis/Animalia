namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Lopholaimus;

/// <summary>
/// Interface defining characteristics of Lopholaimus (genus).
/// </summary>
public interface ILopholaimus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
