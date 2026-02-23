namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Iguanodectes;

/// <summary>
/// Interface defining characteristics of Iguanodectes (genus).
/// </summary>
public interface IIguanodectes
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
