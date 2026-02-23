namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Pelodryas;

/// <summary>
/// Species: Pelodryas splendida x Pelodryas caerulea
/// NCBI TaxId: 3109966
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodryas_splendida_x_Pelodryas_caerulea : Pelodryas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodryas splendida x Pelodryas caerulea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodryas_splendida_x_Pelodryas_caerulea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3109966;
}
