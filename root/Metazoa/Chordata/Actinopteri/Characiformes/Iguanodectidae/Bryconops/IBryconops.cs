namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Bryconops;

/// <summary>
/// Interface defining characteristics of Bryconops (genus).
/// </summary>
public interface IBryconops
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
