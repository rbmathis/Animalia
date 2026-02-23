namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Rhinocryptidae.Scytalopus;

/// <summary>
/// Species: Scytalopus magellanicus
/// NCBI TaxId: 9169
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scytalopus_magellanicus : Scytalopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scytalopus magellanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scytalopus_magellanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9169;
}
