namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Graphiurus;

/// <summary>
/// Interface defining characteristics of Graphiurus (genus).
/// </summary>
public interface IGraphiurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
