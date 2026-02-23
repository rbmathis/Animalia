namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Felidae.Felidae_incertae_sedis.Smilodon;

/// <summary>
/// Species: Smilodon populator
/// NCBI TaxId: 339609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Smilodon_populator : Smilodon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Smilodon populator";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Smilodon_populator";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 339609;
}
