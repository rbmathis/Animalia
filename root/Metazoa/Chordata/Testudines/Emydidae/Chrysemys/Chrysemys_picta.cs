namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Chrysemys;

/// <summary>
/// Species: Chrysemys picta
/// NCBI TaxId: 8479
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chrysemys_picta : Chrysemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chrysemys picta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chrysemys_picta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8479;
}
