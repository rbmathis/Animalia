namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Chimaeridae.Chimaera;

/// <summary>
/// Species: Chimaera sp. MNHN 2007-1555
/// NCBI TaxId: 862825
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chimaera_sp_MNHN_2007_1555 : Chimaera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chimaera sp. MNHN 2007-1555";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chimaera_sp_MNHN_2007_1555";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 862825;
}
