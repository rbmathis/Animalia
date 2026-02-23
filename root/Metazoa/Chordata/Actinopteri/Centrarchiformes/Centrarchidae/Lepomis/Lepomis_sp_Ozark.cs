namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Lepomis;

/// <summary>
/// Species: Lepomis sp. Ozark
/// NCBI TaxId: 2769804
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepomis_sp_Ozark : Lepomis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepomis sp. Ozark";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepomis_sp_Ozark";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2769804;
}
