namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Anoura;

/// <summary>
/// Species: Anoura aequatoris
/// NCBI TaxId: 3045830
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anoura_aequatoris : Anoura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anoura aequatoris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anoura_aequatoris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3045830;
}
