namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Aldabrachelys;

/// <summary>
/// Species: Aldabrachelys abrupta
/// NCBI TaxId: 174717
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aldabrachelys_abrupta : Aldabrachelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aldabrachelys abrupta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aldabrachelys_abrupta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 174717;
}
