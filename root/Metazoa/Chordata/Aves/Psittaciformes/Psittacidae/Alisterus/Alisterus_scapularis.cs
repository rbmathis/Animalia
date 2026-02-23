namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Alisterus;

/// <summary>
/// Species: Alisterus scapularis
/// NCBI TaxId: 458117
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alisterus_scapularis : Alisterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alisterus scapularis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alisterus_scapularis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 458117;
}
