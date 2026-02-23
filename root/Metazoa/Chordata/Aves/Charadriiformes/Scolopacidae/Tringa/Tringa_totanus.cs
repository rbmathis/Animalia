namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Tringa;

/// <summary>
/// Species: Tringa totanus
/// NCBI TaxId: 171271
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tringa_totanus : Tringa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tringa totanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tringa_totanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 171271;
}
