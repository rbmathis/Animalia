using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Leptocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Leptocephalus.unclassified_Leptocephalus;

/// <summary>
/// Abstract class for unclassified Leptocephalus (no rank).
/// NCBI TaxId: 2624272
/// </summary>
public abstract class unclassified_Leptocephalus : Leptocephalus, Iunclassified_Leptocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624272;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptocephalus";
}
