namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella sp. Madeira
/// NCBI TaxId: 3234222
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_sp_Madeira : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella sp. Madeira";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_sp_Madeira";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3234222;
}
