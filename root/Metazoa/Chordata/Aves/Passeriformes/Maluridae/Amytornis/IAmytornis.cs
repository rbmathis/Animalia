namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Amytornis;

/// <summary>
/// Interface defining characteristics of Amytornis (genus).
/// </summary>
public interface IAmytornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
