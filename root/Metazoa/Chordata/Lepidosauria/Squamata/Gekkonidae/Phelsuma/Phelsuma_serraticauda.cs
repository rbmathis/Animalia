namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Phelsuma;

/// <summary>
/// Species: Phelsuma serraticauda
/// NCBI TaxId: 42751
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phelsuma_serraticauda : Phelsuma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phelsuma serraticauda";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phelsuma_serraticauda";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 42751;
}
