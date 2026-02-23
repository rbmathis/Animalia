namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Nibea;

/// <summary>
/// Species: Nibea albiflora
/// NCBI TaxId: 240163
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nibea_albiflora : Nibea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nibea albiflora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nibea_albiflora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 240163;
}
