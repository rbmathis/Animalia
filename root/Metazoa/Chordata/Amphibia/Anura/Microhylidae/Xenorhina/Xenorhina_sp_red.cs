namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Xenorhina;

/// <summary>
/// Species: Xenorhina sp. red
/// NCBI TaxId: 3393582
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenorhina_sp_red : Xenorhina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenorhina sp. red";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenorhina_sp_red";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3393582;
}
