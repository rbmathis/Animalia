namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Bramus;

/// <summary>
/// Species: Bramus lutescens
/// NCBI TaxId: 3370998
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bramus_lutescens : Bramus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bramus lutescens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bramus_lutescens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370998;
}
