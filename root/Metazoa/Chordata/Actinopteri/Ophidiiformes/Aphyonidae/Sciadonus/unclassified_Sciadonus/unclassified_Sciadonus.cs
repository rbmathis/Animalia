using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae.Sciadonus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae.Sciadonus.unclassified_Sciadonus;

/// <summary>
/// Abstract class for unclassified Sciadonus (no rank).
/// NCBI TaxId: 3415247
/// </summary>
public abstract class unclassified_Sciadonus : Sciadonus, Iunclassified_Sciadonus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sciadonus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3415247;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sciadonus";
}
