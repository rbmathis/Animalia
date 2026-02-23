using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Dorcatragus;

/// <summary>
/// Abstract class for Dorcatragus (genus).
/// NCBI TaxId: 1027982
/// </summary>
public abstract class Dorcatragus : Bovidae, IDorcatragus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dorcatragus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1027982;

    /// <inheritdoc />
    public virtual string GenusName => "Dorcatragus";

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
