namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella sp. Western Am
/// NCBI TaxId: 3092183
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_sp_Western_Am : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella sp. Western Am";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_sp_Western_Am";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3092183;
}
