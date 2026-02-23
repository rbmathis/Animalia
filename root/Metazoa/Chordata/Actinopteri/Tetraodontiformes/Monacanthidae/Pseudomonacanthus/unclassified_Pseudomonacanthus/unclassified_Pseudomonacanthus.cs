using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pseudomonacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Pseudomonacanthus.unclassified_Pseudomonacanthus;

/// <summary>
/// Abstract class for unclassified Pseudomonacanthus (no rank).
/// NCBI TaxId: 3045304
/// </summary>
public abstract class unclassified_Pseudomonacanthus : Pseudomonacanthus, Iunclassified_Pseudomonacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudomonacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3045304;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudomonacanthus";
}
