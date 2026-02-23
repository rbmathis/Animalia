namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Acipenser;

/// <summary>
/// Species: Acipenser sp. IMCB-2001
/// NCBI TaxId: 172544
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acipenser_sp_IMCB_2001 : Acipenser
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acipenser sp. IMCB-2001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acipenser_sp_IMCB_2001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172544;
}
