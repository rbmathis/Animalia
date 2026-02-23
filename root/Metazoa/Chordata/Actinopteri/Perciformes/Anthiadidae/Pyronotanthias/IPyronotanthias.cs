namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Anthiadidae.Pyronotanthias;

/// <summary>
/// Interface defining characteristics of Pyronotanthias (genus).
/// </summary>
public interface IPyronotanthias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
