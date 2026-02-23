using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Cyclorana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Cyclorana.unclassified_Cyclorana;

/// <summary>
/// Abstract class for unclassified Cyclorana (no rank).
/// NCBI TaxId: 3136593
/// </summary>
public abstract class unclassified_Cyclorana : Cyclorana, Iunclassified_Cyclorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyclorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3136593;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyclorana";
}
