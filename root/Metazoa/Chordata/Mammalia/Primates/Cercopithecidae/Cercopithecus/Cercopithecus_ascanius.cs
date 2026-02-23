namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cercopithecidae.Cercopithecus;

/// <summary>
/// Species: Cercopithecus ascanius
/// NCBI TaxId: 36223
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cercopithecus_ascanius : Cercopithecus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cercopithecus ascanius";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cercopithecus_ascanius";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 36223;
}
