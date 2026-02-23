using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Priacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Priacanthiformes.Priacanthidae.Priacanthus.unclassified_Priacanthus;

/// <summary>
/// Abstract class for unclassified Priacanthus (no rank).
/// NCBI TaxId: 2677802
/// </summary>
public abstract class unclassified_Priacanthus : Priacanthus, Iunclassified_Priacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Priacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2677802;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Priacanthus";
}
