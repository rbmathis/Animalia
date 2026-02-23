using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Ingerana;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Ingerana.unclassified_Ingerana;

/// <summary>
/// Abstract class for unclassified Ingerana (no rank).
/// NCBI TaxId: 2621211
/// </summary>
public abstract class unclassified_Ingerana : Ingerana, Iunclassified_Ingerana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ingerana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621211;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ingerana";
}
