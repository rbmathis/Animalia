namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Phelsuma;

/// <summary>
/// Species: Phelsuma laticauda
/// NCBI TaxId: 143529
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phelsuma_laticauda : Phelsuma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phelsuma laticauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phelsuma_laticauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 143529;
}
