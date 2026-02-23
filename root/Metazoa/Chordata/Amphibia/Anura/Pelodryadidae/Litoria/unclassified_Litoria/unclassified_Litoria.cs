using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Litoria;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Litoria.unclassified_Litoria;

/// <summary>
/// Abstract class for unclassified Litoria (no rank).
/// NCBI TaxId: 2645308
/// </summary>
public abstract class unclassified_Litoria : Litoria, Iunclassified_Litoria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Litoria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645308;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Litoria";
}
