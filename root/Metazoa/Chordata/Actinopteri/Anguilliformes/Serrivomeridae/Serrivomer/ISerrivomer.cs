namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Serrivomeridae.Serrivomer;

/// <summary>
/// Interface defining characteristics of Serrivomer (genus).
/// </summary>
public interface ISerrivomer
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
