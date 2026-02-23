using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Spilotes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Spilotes.unclassified_Spilotes;

/// <summary>
/// Abstract class for unclassified Spilotes (no rank).
/// NCBI TaxId: 2903331
/// </summary>
public abstract class unclassified_Spilotes : Spilotes, Iunclassified_Spilotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spilotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2903331;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spilotes";
}
