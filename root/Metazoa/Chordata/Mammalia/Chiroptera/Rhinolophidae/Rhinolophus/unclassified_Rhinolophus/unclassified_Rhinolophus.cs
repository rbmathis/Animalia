using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae.Rhinolophus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Rhinolophidae.Rhinolophus.unclassified_Rhinolophus;

/// <summary>
/// Abstract class for unclassified Rhinolophus (no rank).
/// NCBI TaxId: 2629890
/// </summary>
public abstract class unclassified_Rhinolophus : Rhinolophus, Iunclassified_Rhinolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhinolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629890;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhinolophus";
}
