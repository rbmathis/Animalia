namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Reganella;

/// <summary>
/// Interface defining characteristics of Reganella (genus).
/// </summary>
public interface IReganella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
