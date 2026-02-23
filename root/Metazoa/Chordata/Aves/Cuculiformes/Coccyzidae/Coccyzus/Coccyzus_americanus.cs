namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Coccyzidae.Coccyzus;

/// <summary>
/// Species: Coccyzus americanus
/// NCBI TaxId: 33603
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coccyzus_americanus : Coccyzus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coccyzus americanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coccyzus_americanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33603;
}
