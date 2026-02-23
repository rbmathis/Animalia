namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Monacanthus;

/// <summary>
/// Species: Monacanthus radiatus
/// NCBI TaxId: 3000629
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monacanthus_radiatus : Monacanthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monacanthus radiatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monacanthus_radiatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3000629;
}
