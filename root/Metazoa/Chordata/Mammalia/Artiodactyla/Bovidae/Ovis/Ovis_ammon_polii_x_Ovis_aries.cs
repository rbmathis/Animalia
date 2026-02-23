namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Ovis;

/// <summary>
/// Species: Ovis ammon polii x Ovis aries
/// NCBI TaxId: 2918886
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ovis_ammon_polii_x_Ovis_aries : Ovis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ovis ammon polii x Ovis aries";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ovis_ammon_polii_x_Ovis_aries";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2918886;
}
