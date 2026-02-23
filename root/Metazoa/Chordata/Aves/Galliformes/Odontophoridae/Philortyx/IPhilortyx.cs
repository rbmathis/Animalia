namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Philortyx;

/// <summary>
/// Interface defining characteristics of Philortyx (genus).
/// </summary>
public interface IPhilortyx
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
