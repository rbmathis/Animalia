using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Octodontidae.Octodon;

/// <summary>
/// Abstract class for Octodon (genus).
/// NCBI TaxId: 10159
/// </summary>
public abstract class Octodon : Octodontidae, IOctodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Octodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10159;

    /// <inheritdoc />
    public virtual string GenusName => "Octodon";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
