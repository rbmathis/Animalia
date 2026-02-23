using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Brotula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Ophidiidae.Brotula.unclassified_Brotula;

/// <summary>
/// Abstract class for unclassified Brotula (no rank).
/// NCBI TaxId: 2645533
/// </summary>
public abstract class unclassified_Brotula : Brotula, Iunclassified_Brotula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brotula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645533;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brotula";
}
