namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Anguidae.Anguis;

/// <summary>
/// Species: Anguis sp. 1 VG-2013
/// NCBI TaxId: 1338380
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anguis_sp_1_VG_2013 : Anguis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anguis sp. 1 VG-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anguis_sp_1_VG_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1338380;
}
