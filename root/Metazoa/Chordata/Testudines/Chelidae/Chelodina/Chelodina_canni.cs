namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Chelodina;

/// <summary>
/// Species: Chelodina canni
/// NCBI TaxId: 742143
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chelodina_canni : Chelodina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chelodina canni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chelodina_canni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 742143;
}
