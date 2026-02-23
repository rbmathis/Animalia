using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Ischnocnema;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brachycephalidae.Ischnocnema.unclassified_Ischnocnema;

/// <summary>
/// Abstract class for unclassified Ischnocnema (no rank).
/// NCBI TaxId: 2640035
/// </summary>
public abstract class unclassified_Ischnocnema : Ischnocnema, Iunclassified_Ischnocnema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ischnocnema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640035;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ischnocnema";
}
