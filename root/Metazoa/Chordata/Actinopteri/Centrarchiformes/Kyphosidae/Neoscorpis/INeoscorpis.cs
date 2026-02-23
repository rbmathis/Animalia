namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kyphosidae.Neoscorpis;

/// <summary>
/// Interface defining characteristics of Neoscorpis (genus).
/// </summary>
public interface INeoscorpis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
