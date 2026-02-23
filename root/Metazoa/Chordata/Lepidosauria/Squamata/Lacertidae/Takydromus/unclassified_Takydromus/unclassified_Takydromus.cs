using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Takydromus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Takydromus.unclassified_Takydromus;

/// <summary>
/// Abstract class for unclassified Takydromus (no rank).
/// NCBI TaxId: 2646963
/// </summary>
public abstract class unclassified_Takydromus : Takydromus, Iunclassified_Takydromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Takydromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646963;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Takydromus";
}
