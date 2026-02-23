namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelidae.Elseya;

/// <summary>
/// Species: Elseya lavarackorum
/// NCBI TaxId: 321138
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elseya_lavarackorum : Elseya
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elseya lavarackorum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elseya_lavarackorum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 321138;
}
