namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Phylloscopus;

/// <summary>
/// Species: Phylloscopus griseolus
/// NCBI TaxId: 163864
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phylloscopus_griseolus : Phylloscopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phylloscopus griseolus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phylloscopus_griseolus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 163864;
}
