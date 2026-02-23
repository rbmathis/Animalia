namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Alouatta;

/// <summary>
/// Species: Alouatta ululata
/// NCBI TaxId: 2905218
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alouatta_ululata : Alouatta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alouatta ululata";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alouatta_ululata";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2905218;
}
