namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Petromyscus;

/// <summary>
/// Species: Petromyscus sp. RWM-2011
/// NCBI TaxId: 1088705
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Petromyscus_sp_RWM_2011 : Petromyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Petromyscus sp. RWM-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Petromyscus_sp_RWM_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1088705;
}
