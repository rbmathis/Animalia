using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene.unclassified_Terrapene;

/// <summary>
/// Abstract class for unclassified Terrapene (no rank).
/// NCBI TaxId: 2641109
/// </summary>
public abstract class unclassified_Terrapene : Terrapene, Iunclassified_Terrapene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Terrapene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641109;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Terrapene";
}
