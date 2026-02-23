namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Sciaenops;

/// <summary>
/// Species: Sciaenops ocellatus
/// NCBI TaxId: 76340
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciaenops_ocellatus : Sciaenops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciaenops ocellatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciaenops_ocellatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 76340;
}
