namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lobotiformes.Lobotidae.Lobotes;

/// <summary>
/// Interface defining characteristics of Lobotes (genus).
/// </summary>
public interface ILobotes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
