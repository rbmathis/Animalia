namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Galeocerdo;

/// <summary>
/// Species: Galeocerdo cf. cuvier GJPN-2012
/// NCBI TaxId: 1214685
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Galeocerdo_cf_cuvier_GJPN_2012 : Galeocerdo
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Galeocerdo cf. cuvier GJPN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Galeocerdo_cf_cuvier_GJPN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1214685;
}
