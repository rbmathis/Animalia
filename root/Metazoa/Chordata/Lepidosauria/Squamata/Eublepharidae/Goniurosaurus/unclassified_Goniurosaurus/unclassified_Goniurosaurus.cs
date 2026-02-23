using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Goniurosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Eublepharidae.Goniurosaurus.unclassified_Goniurosaurus;

/// <summary>
/// Abstract class for unclassified Goniurosaurus (no rank).
/// NCBI TaxId: 2625494
/// </summary>
public abstract class unclassified_Goniurosaurus : Goniurosaurus, Iunclassified_Goniurosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Goniurosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625494;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Goniurosaurus";
}
