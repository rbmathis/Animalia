namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Sciurotamias;

/// <summary>
/// Interface defining characteristics of Sciurotamias (genus).
/// </summary>
public interface ISciurotamias
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
