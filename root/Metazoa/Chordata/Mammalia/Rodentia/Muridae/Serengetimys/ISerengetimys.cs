namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Serengetimys;

/// <summary>
/// Interface defining characteristics of Serengetimys (genus).
/// </summary>
public interface ISerengetimys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
