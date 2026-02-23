namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Species: Draco punctatus
/// NCBI TaxId: 2126521
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Draco_punctatus : Draco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Draco punctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Draco_punctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2126521;
}
