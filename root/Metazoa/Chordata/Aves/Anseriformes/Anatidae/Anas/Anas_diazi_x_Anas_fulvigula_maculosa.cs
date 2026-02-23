namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas diazi x Anas fulvigula maculosa
/// NCBI TaxId: 3144873
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_diazi_x_Anas_fulvigula_maculosa : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas diazi x Anas fulvigula maculosa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_diazi_x_Anas_fulvigula_maculosa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3144873;
}
