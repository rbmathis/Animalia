namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bison;

/// <summary>
/// Species: Bison schoetensacki
/// NCBI TaxId: 1920185
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bison_schoetensacki : Bison
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bison schoetensacki";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bison_schoetensacki";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1920185;
}
