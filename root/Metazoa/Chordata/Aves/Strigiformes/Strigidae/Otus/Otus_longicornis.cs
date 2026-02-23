namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Otus;

/// <summary>
/// Species: Otus longicornis
/// NCBI TaxId: 56272
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Otus_longicornis : Otus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Otus longicornis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Otus_longicornis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56272;
}
