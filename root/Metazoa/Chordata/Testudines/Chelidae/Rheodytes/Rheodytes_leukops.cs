namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Rheodytes;

/// <summary>
/// Species: Rheodytes leukops
/// NCBI TaxId: 44528
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rheodytes_leukops : Rheodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rheodytes leukops";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rheodytes_leukops";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44528;
}
