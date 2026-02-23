namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Astrochelys;

/// <summary>
/// Species: Astrochelys yniphora
/// NCBI TaxId: 532073
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Astrochelys_yniphora : Astrochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Astrochelys yniphora";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Astrochelys_yniphora";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 532073;
}
