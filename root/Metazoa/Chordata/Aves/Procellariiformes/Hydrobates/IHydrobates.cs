namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Procellariiformes.Hydrobates;

/// <summary>
/// Interface defining characteristics of Hydrobates (genus).
/// </summary>
public interface IHydrobates
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
