namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Ptilinopus;

/// <summary>
/// Species: Ptilinopus perlatus
/// NCBI TaxId: 1390998
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ptilinopus_perlatus : Ptilinopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ptilinopus perlatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ptilinopus_perlatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1390998;
}
