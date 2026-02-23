namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Viverra;

/// <summary>
/// Interface defining characteristics of Viverra (genus).
/// </summary>
public interface IViverra
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
