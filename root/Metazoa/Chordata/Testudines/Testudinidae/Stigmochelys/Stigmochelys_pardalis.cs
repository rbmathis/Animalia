namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Stigmochelys;

/// <summary>
/// Species: Stigmochelys pardalis
/// NCBI TaxId: 569598
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stigmochelys_pardalis : Stigmochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stigmochelys pardalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stigmochelys_pardalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 569598;
}
