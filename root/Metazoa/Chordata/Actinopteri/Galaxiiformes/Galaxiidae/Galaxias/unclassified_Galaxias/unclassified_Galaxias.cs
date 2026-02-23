using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Galaxias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Galaxiiformes.Galaxiidae.Galaxias.unclassified_Galaxias;

/// <summary>
/// Abstract class for unclassified Galaxias (no rank).
/// NCBI TaxId: 2623843
/// </summary>
public abstract class unclassified_Galaxias : Galaxias, Iunclassified_Galaxias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Galaxias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623843;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Galaxias";
}
