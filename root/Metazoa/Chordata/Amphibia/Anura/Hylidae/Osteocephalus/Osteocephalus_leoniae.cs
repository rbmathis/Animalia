namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus;

/// <summary>
/// Species: Osteocephalus leoniae
/// NCBI TaxId: 1329756
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteocephalus_leoniae : Osteocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteocephalus leoniae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteocephalus_leoniae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1329756;
}
