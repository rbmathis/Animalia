namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Falcipennis;

/// <summary>
/// Interface defining characteristics of Falcipennis (genus).
/// </summary>
public interface IFalcipennis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
