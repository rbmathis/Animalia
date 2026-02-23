namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Cervidae.Cervus;

/// <summary>
/// Species: Cervus elaphus
/// NCBI TaxId: 9860
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cervus_elaphus : Cervus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cervus elaphus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cervus_elaphus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9860;
}
