namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Leiosauridae.Leiosaurus;

/// <summary>
/// Species: Leiosaurus jaguaris
/// NCBI TaxId: 1737111
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leiosaurus_jaguaris : Leiosaurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leiosaurus jaguaris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leiosaurus_jaguaris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1737111;
}
