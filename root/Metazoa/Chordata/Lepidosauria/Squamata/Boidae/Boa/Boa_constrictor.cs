namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Boidae.Boa;

/// <summary>
/// Species: Boa constrictor
/// NCBI TaxId: 8574
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Boa_constrictor : Boa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Boa constrictor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Boa_constrictor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8574;
}
