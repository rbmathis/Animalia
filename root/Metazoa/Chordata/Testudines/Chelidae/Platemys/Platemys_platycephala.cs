namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Platemys;

/// <summary>
/// Species: Platemys platycephala
/// NCBI TaxId: 44504
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Platemys_platycephala : Platemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Platemys platycephala";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Platemys_platycephala";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 44504;
}
