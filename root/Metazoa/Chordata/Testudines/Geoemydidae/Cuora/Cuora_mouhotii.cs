namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora mouhotii
/// NCBI TaxId: 260627
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_mouhotii : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora mouhotii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_mouhotii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260627;
}
