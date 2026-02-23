namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Pampa;

/// <summary>
/// Species: Pampa rufa
/// NCBI TaxId: 3150281
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pampa_rufa : Pampa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pampa rufa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pampa_rufa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3150281;
}
