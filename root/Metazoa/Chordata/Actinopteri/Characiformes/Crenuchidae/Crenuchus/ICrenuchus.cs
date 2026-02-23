namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Crenuchidae.Crenuchus;

/// <summary>
/// Interface defining characteristics of Crenuchus (genus).
/// </summary>
public interface ICrenuchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
