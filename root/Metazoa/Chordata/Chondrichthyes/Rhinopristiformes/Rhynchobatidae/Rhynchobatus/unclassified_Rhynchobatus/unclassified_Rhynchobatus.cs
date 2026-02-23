using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae.Rhynchobatus;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhynchobatidae.Rhynchobatus.unclassified_Rhynchobatus;

/// <summary>
/// Abstract class for unclassified Rhynchobatus (no rank).
/// NCBI TaxId: 2623175
/// </summary>
public abstract class unclassified_Rhynchobatus : Rhynchobatus, Iunclassified_Rhynchobatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhynchobatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2623175;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhynchobatus";
}
