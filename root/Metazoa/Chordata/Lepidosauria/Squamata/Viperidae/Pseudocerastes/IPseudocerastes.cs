namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Pseudocerastes;

/// <summary>
/// Interface defining characteristics of Pseudocerastes (genus).
/// </summary>
public interface IPseudocerastes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
