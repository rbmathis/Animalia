namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Mikrogeophagus;

/// <summary>
/// Interface defining characteristics of Mikrogeophagus (genus).
/// </summary>
public interface IMikrogeophagus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
