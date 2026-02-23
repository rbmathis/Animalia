namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calomys;

/// <summary>
/// Species: Calomys callosus
/// NCBI TaxId: 56210
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Calomys_callosus : Calomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Calomys callosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Calomys_callosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56210;
}
