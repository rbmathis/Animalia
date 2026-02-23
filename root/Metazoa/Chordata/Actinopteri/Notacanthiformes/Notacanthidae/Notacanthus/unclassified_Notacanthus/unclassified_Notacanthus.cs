using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Notacanthus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Notacanthiformes.Notacanthidae.Notacanthus.unclassified_Notacanthus;

/// <summary>
/// Abstract class for unclassified Notacanthus (no rank).
/// NCBI TaxId: 2624161
/// </summary>
public abstract class unclassified_Notacanthus : Notacanthus, Iunclassified_Notacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Notacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624161;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Notacanthus";
}
