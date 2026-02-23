namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycaon;

/// <summary>
/// Species: Lycaon pictus
/// NCBI TaxId: 9622
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lycaon_pictus : Lycaon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lycaon pictus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lycaon_pictus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9622;
}
