namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Glyphoglossus;

/// <summary>
/// Species: Glyphoglossus molossus
/// NCBI TaxId: 310869
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Glyphoglossus_molossus : Glyphoglossus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Glyphoglossus molossus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Glyphoglossus_molossus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 310869;
}
