using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.environmental_samples;

/// <summary>
/// Abstract class for environmental samples (no rank).
/// NCBI TaxId: 1617257
/// </summary>
public abstract class environmental_samples : Chiroptera, Ienvironmental_samples
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "environmental samples";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1617257;

    /// <inheritdoc />
    public virtual string Description => "Taxon: environmental_samples";
}
