using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Limnonectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Limnonectes.unclassified_Limnonectes;

/// <summary>
/// Abstract class for unclassified Limnonectes (no rank).
/// NCBI TaxId: 2640364
/// </summary>
public abstract class unclassified_Limnonectes : Limnonectes, Iunclassified_Limnonectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Limnonectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640364;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Limnonectes";
}
