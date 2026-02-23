namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Myiodynastes;

/// <summary>
/// Species: Myiodynastes maculatus
/// NCBI TaxId: 478610
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myiodynastes_maculatus : Myiodynastes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myiodynastes maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myiodynastes_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 478610;
}
