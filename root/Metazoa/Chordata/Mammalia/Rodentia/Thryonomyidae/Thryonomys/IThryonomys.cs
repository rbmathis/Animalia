namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae.Thryonomys;

/// <summary>
/// Interface defining characteristics of Thryonomys (genus).
/// </summary>
public interface IThryonomys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
