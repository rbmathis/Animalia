using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Geocrinia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Geocrinia.unclassified_Geocrinia;

/// <summary>
/// Abstract class for unclassified Geocrinia (no rank).
/// NCBI TaxId: 3243738
/// </summary>
public abstract class unclassified_Geocrinia : Geocrinia, Iunclassified_Geocrinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Geocrinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3243738;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Geocrinia";
}
