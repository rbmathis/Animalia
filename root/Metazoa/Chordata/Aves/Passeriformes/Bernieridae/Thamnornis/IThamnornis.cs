namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Bernieridae.Thamnornis;

/// <summary>
/// Interface defining characteristics of Thamnornis (genus).
/// </summary>
public interface IThamnornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
