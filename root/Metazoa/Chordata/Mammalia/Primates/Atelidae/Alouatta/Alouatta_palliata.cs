namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Species: Alouatta palliata
/// NCBI TaxId: 30589
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alouatta_palliata : Alouatta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alouatta palliata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alouatta_palliata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30589;
}
