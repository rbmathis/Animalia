namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Loxops;

/// <summary>
/// Interface defining characteristics of Loxops (genus).
/// </summary>
public interface ILoxops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
