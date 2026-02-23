namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hylarana;

/// <summary>
/// Species: Hylarana sp. 2 CDS-2013
/// NCBI TaxId: 1380803
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylarana_sp_2_CDS_2013 : Hylarana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylarana sp. 2 CDS-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylarana_sp_2_CDS_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1380803;
}
