namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Testudinidae.Astrochelys;

/// <summary>
/// Species: Astrochelys radiata
/// NCBI TaxId: 66190
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Astrochelys_radiata : Astrochelys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Astrochelys radiata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Astrochelys_radiata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 66190;
}
