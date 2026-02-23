using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Semionotiformes.unclassified_Semionotiformes;

/// <summary>
/// Abstract class for unclassified Semionotiformes (no rank).
/// NCBI TaxId: 794807
/// </summary>
public abstract class unclassified_Semionotiformes : Semionotiformes, Iunclassified_Semionotiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Semionotiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 794807;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Semionotiformes";
}
