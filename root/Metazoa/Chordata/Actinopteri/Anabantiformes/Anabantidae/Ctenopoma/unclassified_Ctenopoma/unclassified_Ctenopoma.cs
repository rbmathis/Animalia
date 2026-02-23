using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Ctenopoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Anabantidae.Ctenopoma.unclassified_Ctenopoma;

/// <summary>
/// Abstract class for unclassified Ctenopoma (no rank).
/// NCBI TaxId: 2637778
/// </summary>
public abstract class unclassified_Ctenopoma : Ctenopoma, Iunclassified_Ctenopoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ctenopoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637778;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ctenopoma";
}
