namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pilosa.Megatheriidae.Megatherium;

/// <summary>
/// Species: Megatherium americanum
/// NCBI TaxId: 2546660
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Megatherium_americanum : Megatherium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Megatherium americanum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Megatherium_americanum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2546660;
}
