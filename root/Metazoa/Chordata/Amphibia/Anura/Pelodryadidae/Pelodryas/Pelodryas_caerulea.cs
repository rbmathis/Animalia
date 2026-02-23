namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Pelodryas;

/// <summary>
/// Species: Pelodryas caerulea
/// NCBI TaxId: 30344
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodryas_caerulea : Pelodryas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodryas caerulea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodryas_caerulea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30344;
}
