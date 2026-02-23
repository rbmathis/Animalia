using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Crinia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Crinia.unclassified_Crinia;

/// <summary>
/// Abstract class for unclassified Crinia (no rank).
/// NCBI TaxId: 2644840
/// </summary>
public abstract class unclassified_Crinia : Crinia, Iunclassified_Crinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Crinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644840;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Crinia";
}
