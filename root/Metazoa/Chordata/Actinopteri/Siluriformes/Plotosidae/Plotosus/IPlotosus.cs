namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Plotosus;

/// <summary>
/// Interface defining characteristics of Plotosus (genus).
/// </summary>
public interface IPlotosus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
