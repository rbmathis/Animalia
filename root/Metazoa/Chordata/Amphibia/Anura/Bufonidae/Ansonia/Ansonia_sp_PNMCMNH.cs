namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Ansonia;

/// <summary>
/// Species: Ansonia sp. PNM/CMNH
/// NCBI TaxId: 248775
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ansonia_sp_PNMCMNH : Ansonia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ansonia sp. PNM/CMNH";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ansonia_sp_PNMCMNH";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 248775;
}
