namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Poicephalus;

/// <summary>
/// Species: Poicephalus rueppellii
/// NCBI TaxId: 1549155
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Poicephalus_rueppellii : Poicephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Poicephalus rueppellii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Poicephalus_rueppellii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1549155;
}
