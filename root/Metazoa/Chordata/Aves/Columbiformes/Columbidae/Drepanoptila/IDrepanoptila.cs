namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Drepanoptila;

/// <summary>
/// Interface defining characteristics of Drepanoptila (genus).
/// </summary>
public interface IDrepanoptila
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
