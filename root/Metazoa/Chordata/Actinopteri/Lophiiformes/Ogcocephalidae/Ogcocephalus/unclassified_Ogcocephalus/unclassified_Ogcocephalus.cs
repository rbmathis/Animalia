using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Ogcocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Ogcocephalus.unclassified_Ogcocephalus;

/// <summary>
/// Abstract class for unclassified Ogcocephalus (no rank).
/// NCBI TaxId: 2636785
/// </summary>
public abstract class unclassified_Ogcocephalus : Ogcocephalus, Iunclassified_Ogcocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ogcocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2636785;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ogcocephalus";
}
