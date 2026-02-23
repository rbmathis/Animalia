namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae.Echinorhinus;

/// <summary>
/// Species: Echinorhinus sp. 1 GJPN-2012
/// NCBI TaxId: 1155092
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Echinorhinus_sp_1_GJPN_2012 : Echinorhinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Echinorhinus sp. 1 GJPN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Echinorhinus_sp_1_GJPN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1155092;
}
