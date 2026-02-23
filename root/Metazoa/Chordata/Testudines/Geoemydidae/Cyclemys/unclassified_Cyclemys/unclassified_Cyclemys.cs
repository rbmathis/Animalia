using AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cyclemys.unclassified_Cyclemys;

/// <summary>
/// Abstract class for unclassified Cyclemys (no rank).
/// NCBI TaxId: 2629324
/// </summary>
public abstract class unclassified_Cyclemys : Cyclemys, Iunclassified_Cyclemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyclemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629324;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyclemys";
}
