namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora aurocapitata
/// NCBI TaxId: 72008
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_aurocapitata : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora aurocapitata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_aurocapitata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 72008;
}
