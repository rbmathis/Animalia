namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys hartwegi
/// NCBI TaxId: 3148711
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_hartwegi : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys hartwegi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_hartwegi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3148711;
}
