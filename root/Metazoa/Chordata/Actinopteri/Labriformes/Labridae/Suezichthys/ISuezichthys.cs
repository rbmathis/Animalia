namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Suezichthys;

/// <summary>
/// Interface defining characteristics of Suezichthys (genus).
/// </summary>
public interface ISuezichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
