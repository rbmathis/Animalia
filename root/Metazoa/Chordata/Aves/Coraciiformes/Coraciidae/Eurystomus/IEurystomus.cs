namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Coraciidae.Eurystomus;

/// <summary>
/// Interface defining characteristics of Eurystomus (genus).
/// </summary>
public interface IEurystomus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
