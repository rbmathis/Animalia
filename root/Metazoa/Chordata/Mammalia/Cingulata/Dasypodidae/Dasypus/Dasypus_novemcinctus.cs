namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

/// <summary>
/// Species: Dasypus novemcinctus
/// NCBI TaxId: 9361
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasypus_novemcinctus : Dasypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasypus novemcinctus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasypus_novemcinctus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9361;
}
