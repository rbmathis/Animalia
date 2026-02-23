using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Euphlyctis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Euphlyctis.unclassified_Euphlyctis;

/// <summary>
/// Abstract class for unclassified Euphlyctis (no rank).
/// NCBI TaxId: 2619406
/// </summary>
public abstract class unclassified_Euphlyctis : Euphlyctis, Iunclassified_Euphlyctis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Euphlyctis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619406;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Euphlyctis";
}
