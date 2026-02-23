namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Ctenotus;

/// <summary>
/// Species: Ctenotus taeniolatus
/// NCBI TaxId: 316457
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenotus_taeniolatus : Ctenotus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenotus taeniolatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenotus_taeniolatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 316457;
}
