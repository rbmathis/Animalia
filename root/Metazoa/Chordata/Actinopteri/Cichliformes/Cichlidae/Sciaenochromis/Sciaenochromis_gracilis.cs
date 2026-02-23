namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Sciaenochromis;

/// <summary>
/// Species: Sciaenochromis gracilis
/// NCBI TaxId: 136865
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sciaenochromis_gracilis : Sciaenochromis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sciaenochromis gracilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sciaenochromis_gracilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 136865;
}
