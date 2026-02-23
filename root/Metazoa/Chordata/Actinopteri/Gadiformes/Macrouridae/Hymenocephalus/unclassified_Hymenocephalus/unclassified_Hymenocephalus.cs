using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Hymenocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Hymenocephalus.unclassified_Hymenocephalus;

/// <summary>
/// Abstract class for unclassified Hymenocephalus (no rank).
/// NCBI TaxId: 2623635
/// </summary>
public abstract class unclassified_Hymenocephalus : Hymenocephalus, Iunclassified_Hymenocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hymenocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623635;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hymenocephalus";
}
