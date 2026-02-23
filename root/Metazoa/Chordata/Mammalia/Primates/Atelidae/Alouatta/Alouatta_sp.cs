namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Species: Alouatta sp.
/// NCBI TaxId: 9501
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alouatta_sp : Alouatta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alouatta sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alouatta_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9501;
}
