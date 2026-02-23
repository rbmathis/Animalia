using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae.Centracanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae.Centracanthus.unclassified_Centracanthus;

/// <summary>
/// Abstract class for unclassified Centracanthus (no rank).
/// NCBI TaxId: 2640179
/// </summary>
public abstract class unclassified_Centracanthus : Centracanthus, Iunclassified_Centracanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Centracanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640179;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Centracanthus";
}
