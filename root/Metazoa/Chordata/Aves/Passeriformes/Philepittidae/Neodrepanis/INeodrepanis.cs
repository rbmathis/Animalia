namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Philepittidae.Neodrepanis;

/// <summary>
/// Interface defining characteristics of Neodrepanis (genus).
/// </summary>
public interface INeodrepanis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
