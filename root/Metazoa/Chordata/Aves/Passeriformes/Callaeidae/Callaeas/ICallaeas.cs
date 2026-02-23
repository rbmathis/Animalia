namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Callaeidae.Callaeas;

/// <summary>
/// Interface defining characteristics of Callaeas (genus).
/// </summary>
public interface ICallaeas
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
