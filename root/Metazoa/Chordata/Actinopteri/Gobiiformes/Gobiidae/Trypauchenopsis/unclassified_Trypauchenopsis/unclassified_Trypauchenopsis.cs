using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trypauchenopsis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Trypauchenopsis.unclassified_Trypauchenopsis;

/// <summary>
/// Abstract class for unclassified Trypauchenopsis (no rank).
/// NCBI TaxId: 2626189
/// </summary>
public abstract class unclassified_Trypauchenopsis : Trypauchenopsis, Iunclassified_Trypauchenopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trypauchenopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626189;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trypauchenopsis";
}
