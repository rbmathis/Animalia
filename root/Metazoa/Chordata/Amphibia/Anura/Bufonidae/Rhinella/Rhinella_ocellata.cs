namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Rhinella;

/// <summary>
/// Species: Rhinella ocellata
/// NCBI TaxId: 346456
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinella_ocellata : Rhinella
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinella ocellata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinella_ocellata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 346456;
}
