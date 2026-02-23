using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Butis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Butis.unclassified_Butis;

/// <summary>
/// Abstract class for unclassified Butis (no rank).
/// NCBI TaxId: 2637395
/// </summary>
public abstract class unclassified_Butis : Butis, Iunclassified_Butis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Butis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637395;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Butis";
}
