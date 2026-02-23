namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pseudolithoxus;

/// <summary>
/// Interface defining characteristics of Pseudolithoxus (genus).
/// </summary>
public interface IPseudolithoxus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
