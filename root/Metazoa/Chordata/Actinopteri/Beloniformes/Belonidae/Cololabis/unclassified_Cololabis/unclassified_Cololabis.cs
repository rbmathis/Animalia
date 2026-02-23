using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Cololabis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Cololabis.unclassified_Cololabis;

/// <summary>
/// Abstract class for unclassified Cololabis (no rank).
/// NCBI TaxId: 2641892
/// </summary>
public abstract class unclassified_Cololabis : Cololabis, Iunclassified_Cololabis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cololabis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641892;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cololabis";
}
