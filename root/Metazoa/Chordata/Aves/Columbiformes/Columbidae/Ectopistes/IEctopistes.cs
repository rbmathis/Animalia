namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ectopistes;

/// <summary>
/// Interface defining characteristics of Ectopistes (genus).
/// </summary>
public interface IEctopistes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
