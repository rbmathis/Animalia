namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella sp. Western Amazonia
/// NCBI TaxId: 3090810
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_sp_Western_Amazonia : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella sp. Western Amazonia";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_sp_Western_Amazonia";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3090810;
}
