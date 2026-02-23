namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Motacilla;

/// <summary>
/// Species: Motacilla maderaspatensis
/// NCBI TaxId: 211422
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Motacilla_maderaspatensis : Motacilla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Motacilla maderaspatensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Motacilla_maderaspatensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 211422;
}
