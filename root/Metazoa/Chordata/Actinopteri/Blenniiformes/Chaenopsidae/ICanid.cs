namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Chaenopsidae;

/// <summary>
/// Defines traits specific to canids (dog family).
/// </summary>
public interface ICanid
{
    /// <summary>
    /// Indicates whether the organism has non-retractable claws.
    /// </summary>
    bool HasNonRetractableClaws { get; }

    /// <summary>
    /// Indicates whether the organism is digitigrade (walks on toes).
    /// </summary>
    bool IsDigitigrade { get; }

    /// <summary>
    /// Gets the number of toes on front feet.
    /// </summary>
    int FrontToeCount { get; }

    /// <summary>
    /// Gets the number of toes on hind feet.
    /// </summary>
    int HindToeCount { get; }

    /// <summary>
    /// Gets the communication methods used.
    /// </summary>
    string[] CommunicationMethods { get; }
}
