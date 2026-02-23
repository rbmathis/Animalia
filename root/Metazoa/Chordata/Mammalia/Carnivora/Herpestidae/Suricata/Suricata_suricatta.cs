namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Suricata;

/// <summary>
/// Species: Suricata suricatta
/// NCBI TaxId: 37032
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Suricata_suricatta : Suricata
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Suricata suricatta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Suricata_suricatta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37032;
}
