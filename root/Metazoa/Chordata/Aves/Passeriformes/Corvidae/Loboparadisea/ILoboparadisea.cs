namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Loboparadisea;

/// <summary>
/// Interface defining characteristics of Loboparadisea (genus).
/// </summary>
public interface ILoboparadisea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
