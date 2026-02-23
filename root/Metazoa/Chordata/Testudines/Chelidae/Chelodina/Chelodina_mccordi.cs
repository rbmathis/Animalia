namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina mccordi
/// NCBI TaxId: 904177
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_mccordi : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina mccordi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_mccordi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904177;
}
