namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Sphenisciformes.Spheniscidae.Spheniscus;

/// <summary>
/// Species: Spheniscus mendiculus
/// NCBI TaxId: 156760
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spheniscus_mendiculus : Spheniscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spheniscus mendiculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spheniscus_mendiculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 156760;
}
