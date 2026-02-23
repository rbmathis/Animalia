namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bison;

/// <summary>
/// Species: Bison bison
/// NCBI TaxId: 9901
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bison_bison : Bison
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bison bison";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bison_bison";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9901;
}
