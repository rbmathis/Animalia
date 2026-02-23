namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Siebenrockiella;

/// <summary>
/// Species: Siebenrockiella leytensis
/// NCBI TaxId: 327256
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Siebenrockiella_leytensis : Siebenrockiella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Siebenrockiella leytensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Siebenrockiella_leytensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 327256;
}
