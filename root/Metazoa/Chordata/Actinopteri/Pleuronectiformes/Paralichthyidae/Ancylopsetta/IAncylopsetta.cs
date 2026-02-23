namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Paralichthyidae.Ancylopsetta;

/// <summary>
/// Interface defining characteristics of Ancylopsetta (genus).
/// </summary>
public interface IAncylopsetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
