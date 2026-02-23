namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Anthus;

/// <summary>
/// Species: Anthus spinoletta
/// NCBI TaxId: 45802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anthus_spinoletta : Anthus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anthus spinoletta";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anthus_spinoletta";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 45802;
}
