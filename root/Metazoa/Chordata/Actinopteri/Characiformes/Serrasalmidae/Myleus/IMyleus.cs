namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Myleus;

/// <summary>
/// Interface defining characteristics of Myleus (genus).
/// </summary>
public interface IMyleus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
