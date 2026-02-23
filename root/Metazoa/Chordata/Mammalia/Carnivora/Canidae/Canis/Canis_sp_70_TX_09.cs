namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Canis;

/// <summary>
/// Species: Canis sp
/// NCBI TaxId: 2714675
/// Enrichment Status: Enriched (2026-02-23)
/// </summary>
public class Canis_sp_70_TX_09 : Canis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = true;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Canis sp";

    /// <summary>Gets the common name.</summary>
    public string CommonName => "Canis sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2714675;

    /// <summary>Gets the conservation status.</summary>
    public string ConservationStatus => "Data Deficient";

}
