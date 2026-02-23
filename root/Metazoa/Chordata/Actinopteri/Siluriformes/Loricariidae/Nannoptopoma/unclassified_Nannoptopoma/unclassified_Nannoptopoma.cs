using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Nannoptopoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Nannoptopoma.unclassified_Nannoptopoma;

/// <summary>
/// Abstract class for unclassified Nannoptopoma (no rank).
/// NCBI TaxId: 2635305
/// </summary>
public abstract class unclassified_Nannoptopoma : Nannoptopoma, Iunclassified_Nannoptopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nannoptopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635305;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nannoptopoma";
}
