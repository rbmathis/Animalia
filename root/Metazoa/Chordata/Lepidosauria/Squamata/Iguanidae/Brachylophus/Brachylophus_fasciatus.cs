namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Iguanidae.Brachylophus;

/// <summary>
/// Species: Brachylophus fasciatus
/// NCBI TaxId: 46195
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brachylophus_fasciatus : Brachylophus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brachylophus fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brachylophus_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46195;
}
