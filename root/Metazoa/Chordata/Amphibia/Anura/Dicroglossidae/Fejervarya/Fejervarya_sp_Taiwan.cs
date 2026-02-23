namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Fejervarya;

/// <summary>
/// Species: Fejervarya sp. Taiwan
/// NCBI TaxId: 622605
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Fejervarya_sp_Taiwan : Fejervarya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Fejervarya sp. Taiwan";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Fejervarya_sp_Taiwan";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 622605;
}
