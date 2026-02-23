namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Compsophis;

/// <summary>
/// Interface defining characteristics of Compsophis (genus).
/// </summary>
public interface ICompsophis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
