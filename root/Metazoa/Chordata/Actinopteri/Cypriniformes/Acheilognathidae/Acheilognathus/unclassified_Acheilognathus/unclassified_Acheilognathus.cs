using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Acheilognathus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Acheilognathus.unclassified_Acheilognathus;

/// <summary>
/// Abstract class for unclassified Acheilognathus (no rank).
/// NCBI TaxId: 2633975
/// </summary>
public abstract class unclassified_Acheilognathus : Acheilognathus, Iunclassified_Acheilognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acheilognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633975;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acheilognathus";
}
