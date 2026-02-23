using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Scoliodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Scoliodon.unclassified_Scoliodon;

/// <summary>
/// Abstract class for unclassified Scoliodon (no rank).
/// NCBI TaxId: 2629549
/// </summary>
public abstract class unclassified_Scoliodon : Scoliodon, Iunclassified_Scoliodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scoliodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629549;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scoliodon";
}
