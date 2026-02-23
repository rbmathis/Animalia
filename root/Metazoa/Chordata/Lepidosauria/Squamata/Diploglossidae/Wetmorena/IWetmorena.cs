namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Wetmorena;

/// <summary>
/// Interface defining characteristics of Wetmorena (genus).
/// </summary>
public interface IWetmorena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
