namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Oporornis;

/// <summary>
/// Interface defining characteristics of Oporornis (genus).
/// </summary>
public interface IOporornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
