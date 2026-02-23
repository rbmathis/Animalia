namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Phylloscopus;

/// <summary>
/// Species: Phylloscopus fuscatus
/// NCBI TaxId: 56430
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phylloscopus_fuscatus : Phylloscopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phylloscopus fuscatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phylloscopus_fuscatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 56430;
}
