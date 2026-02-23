using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Myoxocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Myoxocephalus.unclassified_Myoxocephalus;

/// <summary>
/// Abstract class for unclassified Myoxocephalus (no rank).
/// NCBI TaxId: 2994811
/// </summary>
public abstract class unclassified_Myoxocephalus : Myoxocephalus, Iunclassified_Myoxocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myoxocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2994811;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myoxocephalus";
}
