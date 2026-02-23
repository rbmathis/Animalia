namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Scotocercidae.Horornis;

/// <summary>
/// Interface defining characteristics of Horornis (genus).
/// </summary>
public interface IHorornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
