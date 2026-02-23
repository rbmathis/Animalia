namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Squalidae.Squalus;

/// <summary>
/// Species: Squalus albicaudus
/// NCBI TaxId: 2954766
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Squalus_albicaudus : Squalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Squalus albicaudus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Squalus_albicaudus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2954766;
}
