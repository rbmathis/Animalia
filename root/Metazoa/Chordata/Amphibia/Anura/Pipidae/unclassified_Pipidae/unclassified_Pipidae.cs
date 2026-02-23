using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.unclassified_Pipidae;

/// <summary>
/// Abstract class for unclassified Pipidae (no rank).
/// NCBI TaxId: 1702353
/// </summary>
public abstract class unclassified_Pipidae : Pipidae, Iunclassified_Pipidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pipidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1702353;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pipidae";
}
