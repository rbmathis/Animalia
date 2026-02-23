namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufo;

/// <summary>
/// Species: Bufo sp. Yok Don
/// NCBI TaxId: 103436
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bufo_sp_Yok_Don : Bufo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bufo sp. Yok Don";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bufo_sp_Yok_Don";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 103436;
}
