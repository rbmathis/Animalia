namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Phenacogrammus;

/// <summary>
/// Interface defining characteristics of Phenacogrammus (genus).
/// </summary>
public interface IPhenacogrammus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
