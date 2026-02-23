using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Megalechis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Callichthyidae.Megalechis.unclassified_Megalechis;

/// <summary>
/// Abstract class for unclassified Megalechis (no rank).
/// NCBI TaxId: 3101871
/// </summary>
public abstract class unclassified_Megalechis : Megalechis, Iunclassified_Megalechis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Megalechis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101871;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Megalechis";
}
