using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.unclassified_Carcharhiniformes;

/// <summary>
/// Abstract class for unclassified Carcharhiniformes (no rank).
/// NCBI TaxId: 725815
/// </summary>
public abstract class unclassified_Carcharhiniformes : Carcharhiniformes, Iunclassified_Carcharhiniformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Carcharhiniformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725815;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Carcharhiniformes";
}
