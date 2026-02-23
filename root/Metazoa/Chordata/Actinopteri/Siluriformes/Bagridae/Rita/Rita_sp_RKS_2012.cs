namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Rita;

/// <summary>
/// Species: Rita sp. RKS-2012
/// NCBI TaxId: 1269721
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rita_sp_RKS_2012 : Rita
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rita sp. RKS-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rita_sp_RKS_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1269721;
}
