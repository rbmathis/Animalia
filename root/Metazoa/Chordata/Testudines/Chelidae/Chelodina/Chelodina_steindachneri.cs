namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina steindachneri
/// NCBI TaxId: 2080851
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_steindachneri : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina steindachneri";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_steindachneri";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2080851;
}
