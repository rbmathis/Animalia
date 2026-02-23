namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodytidae.Pelodytes;

/// <summary>
/// Species: Pelodytes ibericus x Pelodytes sp. 'SW Portugal'
/// NCBI TaxId: 978108
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodytes_ibericus_x_Pelodytes_sp_SW_Portugal : Pelodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodytes ibericus x Pelodytes sp. 'SW Portugal'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodytes_ibericus_x_Pelodytes_sp_SW_Portugal";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 978108;
}
