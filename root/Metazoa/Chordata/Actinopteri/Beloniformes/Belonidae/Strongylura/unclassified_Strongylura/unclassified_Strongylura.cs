using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Strongylura;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Strongylura.unclassified_Strongylura;

/// <summary>
/// Abstract class for unclassified Strongylura (no rank).
/// NCBI TaxId: 2641637
/// </summary>
public abstract class unclassified_Strongylura : Strongylura, Iunclassified_Strongylura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Strongylura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641637;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Strongylura";
}
