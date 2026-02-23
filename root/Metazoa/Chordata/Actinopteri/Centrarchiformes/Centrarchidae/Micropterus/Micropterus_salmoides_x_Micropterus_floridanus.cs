namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Micropterus;

/// <summary>
/// Species: Micropterus salmoides x Micropterus floridanus
/// NCBI TaxId: 2846758
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Micropterus_salmoides_x_Micropterus_floridanus : Micropterus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Micropterus salmoides x Micropterus floridanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Micropterus_salmoides_x_Micropterus_floridanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2846758;
}
