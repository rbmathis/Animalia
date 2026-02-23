namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Tubulidentata.Orycteropodidae.Orycteropus;

/// <summary>
/// Species: Orycteropus afer
/// NCBI TaxId: 9818
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Orycteropus_afer : Orycteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Orycteropus afer";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Orycteropus_afer";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9818;
}
