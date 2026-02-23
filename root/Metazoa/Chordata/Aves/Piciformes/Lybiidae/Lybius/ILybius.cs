namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Lybius;

/// <summary>
/// Interface defining characteristics of Lybius (genus).
/// </summary>
public interface ILybius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
