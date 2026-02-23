namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Trachemys;

/// <summary>
/// Species: Trachemys sp.
/// NCBI TaxId: 2060764
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachemys_sp : Trachemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachemys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachemys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2060764;
}
