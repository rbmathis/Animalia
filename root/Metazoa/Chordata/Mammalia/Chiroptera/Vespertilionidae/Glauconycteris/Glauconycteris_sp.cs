namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Glauconycteris;

/// <summary>
/// Species: Glauconycteris sp.
/// NCBI TaxId: 3465175
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Glauconycteris_sp : Glauconycteris
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Glauconycteris sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Glauconycteris_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3465175;
}
