namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Osteocephalus;

/// <summary>
/// Species: Osteocephalus sp. (B) VG-2010
/// NCBI TaxId: 712892
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteocephalus_sp_B_VG_2010 : Osteocephalus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteocephalus sp. (B) VG-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteocephalus_sp_B_VG_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 712892;
}
