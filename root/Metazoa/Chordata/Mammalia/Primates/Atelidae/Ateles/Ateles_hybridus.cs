namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Atelidae.Ateles;

/// <summary>
/// Species: Ateles hybridus
/// NCBI TaxId: 129801
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ateles_hybridus : Ateles
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ateles hybridus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ateles_hybridus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 129801;
}
