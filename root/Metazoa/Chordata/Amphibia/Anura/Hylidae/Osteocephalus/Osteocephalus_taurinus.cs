namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus;

/// <summary>
/// Species: Osteocephalus taurinus
/// NCBI TaxId: 248862
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteocephalus_taurinus : Osteocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteocephalus taurinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteocephalus_taurinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 248862;
}
