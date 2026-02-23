namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Thryophilus;

/// <summary>
/// Interface defining characteristics of Thryophilus (genus).
/// </summary>
public interface IThryophilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
