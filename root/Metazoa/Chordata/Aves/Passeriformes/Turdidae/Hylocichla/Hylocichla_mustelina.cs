namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Hylocichla;

/// <summary>
/// Species: Hylocichla mustelina
/// NCBI TaxId: 172420
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylocichla_mustelina : Hylocichla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylocichla mustelina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylocichla_mustelina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172420;
}
