using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Platyceps;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Platyceps.unclassified_Platyceps;

/// <summary>
/// Abstract class for unclassified Platyceps (no rank).
/// NCBI TaxId: 2617965
/// </summary>
public abstract class unclassified_Platyceps : Platyceps, Iunclassified_Platyceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Platyceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617965;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Platyceps";
}
