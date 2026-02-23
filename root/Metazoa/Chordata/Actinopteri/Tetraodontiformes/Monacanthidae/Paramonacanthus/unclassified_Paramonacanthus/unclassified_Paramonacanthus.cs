using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Paramonacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Paramonacanthus.unclassified_Paramonacanthus;

/// <summary>
/// Abstract class for unclassified Paramonacanthus (no rank).
/// NCBI TaxId: 2629593
/// </summary>
public abstract class unclassified_Paramonacanthus : Paramonacanthus, Iunclassified_Paramonacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paramonacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629593;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paramonacanthus";
}
