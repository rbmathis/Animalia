namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Bartramia;

/// <summary>
/// Species: Bartramia sp. (in: birds)
/// NCBI TaxId: 2046150
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bartramia_sp_in_birds : Bartramia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bartramia sp. (in: birds)";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bartramia_sp_in_birds";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2046150;
}
