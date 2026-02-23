namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina kurrichalpongo
/// NCBI TaxId: 3147883
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_kurrichalpongo : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina kurrichalpongo";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_kurrichalpongo";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3147883;
}
