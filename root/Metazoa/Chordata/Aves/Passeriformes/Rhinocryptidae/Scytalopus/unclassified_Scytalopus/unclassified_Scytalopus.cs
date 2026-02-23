using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Scytalopus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Scytalopus.unclassified_Scytalopus;

/// <summary>
/// Abstract class for unclassified Scytalopus (no rank).
/// NCBI TaxId: 2637580
/// </summary>
public abstract class unclassified_Scytalopus : Scytalopus, Iunclassified_Scytalopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scytalopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637580;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scytalopus";
}
