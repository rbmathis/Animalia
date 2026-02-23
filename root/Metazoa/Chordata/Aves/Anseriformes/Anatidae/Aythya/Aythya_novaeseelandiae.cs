namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Aythya;

/// <summary>
/// Species: Aythya novaeseelandiae
/// NCBI TaxId: 2497792
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aythya_novaeseelandiae : Aythya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aythya novaeseelandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aythya_novaeseelandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2497792;
}
