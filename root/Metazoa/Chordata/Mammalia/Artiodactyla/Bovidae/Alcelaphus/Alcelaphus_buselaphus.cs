namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Alcelaphus;

/// <summary>
/// Species: Alcelaphus buselaphus
/// NCBI TaxId: 59517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alcelaphus_buselaphus : Alcelaphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alcelaphus buselaphus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alcelaphus_buselaphus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59517;
}
