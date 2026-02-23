using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.unclassified_Siluriformes;

/// <summary>
/// Abstract class for unclassified Siluriformes (no rank).
/// NCBI TaxId: 71178
/// </summary>
public abstract class unclassified_Siluriformes : Siluriformes, Iunclassified_Siluriformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Siluriformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 71178;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Siluriformes";
}
