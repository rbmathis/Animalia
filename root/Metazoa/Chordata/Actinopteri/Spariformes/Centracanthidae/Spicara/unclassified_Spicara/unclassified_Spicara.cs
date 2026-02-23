using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae.Spicara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Centracanthidae.Spicara.unclassified_Spicara;

/// <summary>
/// Abstract class for unclassified Spicara (no rank).
/// NCBI TaxId: 2629811
/// </summary>
public abstract class unclassified_Spicara : Spicara, Iunclassified_Spicara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spicara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629811;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spicara";
}
