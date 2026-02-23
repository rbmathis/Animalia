using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Elachistocleis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Elachistocleis.unclassified_Elachistocleis;

/// <summary>
/// Abstract class for unclassified Elachistocleis (no rank).
/// NCBI TaxId: 2641412
/// </summary>
public abstract class unclassified_Elachistocleis : Elachistocleis, Iunclassified_Elachistocleis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elachistocleis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641412;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elachistocleis";
}
