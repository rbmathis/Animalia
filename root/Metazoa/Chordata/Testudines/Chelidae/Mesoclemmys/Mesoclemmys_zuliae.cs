namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Mesoclemmys;

/// <summary>
/// Species: Mesoclemmys zuliae
/// NCBI TaxId: 1234952
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesoclemmys_zuliae : Mesoclemmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesoclemmys zuliae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesoclemmys_zuliae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234952;
}
