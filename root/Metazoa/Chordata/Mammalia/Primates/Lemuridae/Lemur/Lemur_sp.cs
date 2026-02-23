namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Lemur;

/// <summary>
/// Species: Lemur sp.
/// NCBI TaxId: 69491
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lemur_sp : Lemur
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lemur sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lemur_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69491;
}
