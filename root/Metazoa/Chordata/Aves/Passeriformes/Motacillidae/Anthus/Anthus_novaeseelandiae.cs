namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Anthus;

/// <summary>
/// Species: Anthus novaeseelandiae
/// NCBI TaxId: 1108006
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anthus_novaeseelandiae : Anthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anthus novaeseelandiae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anthus_novaeseelandiae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1108006;
}
