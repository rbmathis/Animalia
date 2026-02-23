namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Catreus;

/// <summary>
/// Interface defining characteristics of Catreus (genus).
/// </summary>
public interface ICatreus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
