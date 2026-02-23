namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Curimatidae.Pseudocurimata;

/// <summary>
/// Interface defining characteristics of Pseudocurimata (genus).
/// </summary>
public interface IPseudocurimata
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
