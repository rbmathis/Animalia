namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Sternopygus;

/// <summary>
/// Interface defining characteristics of Sternopygus (genus).
/// </summary>
public interface ISternopygus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
