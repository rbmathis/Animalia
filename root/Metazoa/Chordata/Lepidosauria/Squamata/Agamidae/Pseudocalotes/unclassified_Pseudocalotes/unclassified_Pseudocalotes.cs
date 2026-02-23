using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pseudocalotes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Pseudocalotes.unclassified_Pseudocalotes;

/// <summary>
/// Abstract class for unclassified Pseudocalotes (no rank).
/// NCBI TaxId: 2640381
/// </summary>
public abstract class unclassified_Pseudocalotes : Pseudocalotes, Iunclassified_Pseudocalotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudocalotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640381;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudocalotes";
}
