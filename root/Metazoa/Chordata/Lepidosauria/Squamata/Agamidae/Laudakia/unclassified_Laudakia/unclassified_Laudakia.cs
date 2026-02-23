using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Laudakia;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Laudakia.unclassified_Laudakia;

/// <summary>
/// Abstract class for unclassified Laudakia (no rank).
/// NCBI TaxId: 2647996
/// </summary>
public abstract class unclassified_Laudakia : Laudakia, Iunclassified_Laudakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laudakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647996;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laudakia";
}
