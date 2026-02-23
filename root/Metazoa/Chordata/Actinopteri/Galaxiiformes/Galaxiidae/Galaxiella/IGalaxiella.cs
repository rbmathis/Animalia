namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Galaxiella;

/// <summary>
/// Interface defining characteristics of Galaxiella (genus).
/// </summary>
public interface IGalaxiella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
