namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Casuariiformes.Dromaiidae.Dromaius;

/// <summary>
/// Interface defining characteristics of Dromaius (genus).
/// </summary>
public interface IDromaius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
