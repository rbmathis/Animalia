namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Pempheridae.Pempheris;

/// <summary>
/// Interface defining characteristics of Pempheris (genus).
/// </summary>
public interface IPempheris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
