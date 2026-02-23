namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora picturata
/// NCBI TaxId: 241440
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_picturata : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora picturata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_picturata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 241440;
}
