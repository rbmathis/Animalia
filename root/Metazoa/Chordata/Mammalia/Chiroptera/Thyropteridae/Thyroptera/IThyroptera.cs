namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Thyropteridae.Thyroptera;

/// <summary>
/// Interface defining characteristics of Thyroptera (genus).
/// </summary>
public interface IThyroptera
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
