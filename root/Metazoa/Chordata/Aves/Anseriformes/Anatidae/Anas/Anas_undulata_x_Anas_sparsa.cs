namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas undulata x Anas sparsa
/// NCBI TaxId: 3416664
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_undulata_x_Anas_sparsa : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas undulata x Anas sparsa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_undulata_x_Anas_sparsa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3416664;
}
