namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Anampses;

/// <summary>
/// Interface defining characteristics of Anampses (genus).
/// </summary>
public interface IAnampses
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
