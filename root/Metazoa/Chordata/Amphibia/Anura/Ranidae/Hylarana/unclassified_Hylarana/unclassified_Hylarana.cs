using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana.unclassified_Hylarana;

/// <summary>
/// Abstract class for unclassified Hylarana (no rank).
/// NCBI TaxId: 2628866
/// </summary>
public abstract class unclassified_Hylarana : Hylarana, Iunclassified_Hylarana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hylarana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628866;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hylarana";
}
