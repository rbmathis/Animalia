namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Doratonotus;

/// <summary>
/// Interface defining characteristics of Doratonotus (genus).
/// </summary>
public interface IDoratonotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
