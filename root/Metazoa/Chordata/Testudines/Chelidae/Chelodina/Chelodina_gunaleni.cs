namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina gunaleni
/// NCBI TaxId: 2804319
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_gunaleni : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina gunaleni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_gunaleni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2804319;
}
