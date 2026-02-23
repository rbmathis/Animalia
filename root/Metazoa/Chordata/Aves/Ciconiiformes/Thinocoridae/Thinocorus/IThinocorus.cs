namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Thinocoridae.Thinocorus;

/// <summary>
/// Interface defining characteristics of Thinocorus (genus).
/// </summary>
public interface IThinocorus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
