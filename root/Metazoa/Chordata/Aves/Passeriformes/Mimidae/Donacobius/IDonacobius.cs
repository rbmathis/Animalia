namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Mimidae.Donacobius;

/// <summary>
/// Interface defining characteristics of Donacobius (genus).
/// </summary>
public interface IDonacobius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
