namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Pithecopus;

/// <summary>
/// Species: Pithecopus megacephalus
/// NCBI TaxId: 860373
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pithecopus_megacephalus : Pithecopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pithecopus megacephalus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pithecopus_megacephalus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 860373;
}
