namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Terrapene;

/// <summary>
/// Species: Terrapene sp.
/// NCBI TaxId: 2060763
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Terrapene_sp : Terrapene
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Terrapene sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Terrapene_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2060763;
}
