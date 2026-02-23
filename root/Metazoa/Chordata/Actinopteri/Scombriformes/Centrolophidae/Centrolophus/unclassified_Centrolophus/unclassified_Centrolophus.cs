using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Centrolophus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Centrolophidae.Centrolophus.unclassified_Centrolophus;

/// <summary>
/// Abstract class for unclassified Centrolophus (no rank).
/// NCBI TaxId: 2641425
/// </summary>
public abstract class unclassified_Centrolophus : Centrolophus, Iunclassified_Centrolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centrolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641425;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centrolophus";
}
