using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Cantherhines;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Cantherhines.unclassified_Cantherhines;

/// <summary>
/// Abstract class for unclassified Cantherhines (no rank).
/// NCBI TaxId: 3045267
/// </summary>
public abstract class unclassified_Cantherhines : Cantherhines, Iunclassified_Cantherhines
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cantherhines";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3045267;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cantherhines";
}
