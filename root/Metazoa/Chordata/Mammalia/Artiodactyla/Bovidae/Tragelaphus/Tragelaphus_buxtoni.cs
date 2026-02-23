namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Tragelaphus;

/// <summary>
/// Species: Tragelaphus buxtoni
/// NCBI TaxId: 69296
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tragelaphus_buxtoni : Tragelaphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tragelaphus buxtoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tragelaphus_buxtoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 69296;
}
