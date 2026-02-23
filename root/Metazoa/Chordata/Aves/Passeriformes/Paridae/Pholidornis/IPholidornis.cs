namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Pholidornis;

/// <summary>
/// Interface defining characteristics of Pholidornis (genus).
/// </summary>
public interface IPholidornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
