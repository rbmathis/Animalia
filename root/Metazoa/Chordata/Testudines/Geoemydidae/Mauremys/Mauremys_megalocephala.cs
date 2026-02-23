namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Mauremys;

/// <summary>
/// Species: Mauremys megalocephala
/// NCBI TaxId: 260622
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mauremys_megalocephala : Mauremys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mauremys megalocephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mauremys_megalocephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260622;
}
