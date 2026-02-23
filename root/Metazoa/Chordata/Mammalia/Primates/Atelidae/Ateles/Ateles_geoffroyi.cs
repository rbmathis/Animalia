namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

/// <summary>
/// Species: Ateles geoffroyi
/// NCBI TaxId: 9509
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ateles_geoffroyi : Ateles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ateles geoffroyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ateles_geoffroyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9509;
}
