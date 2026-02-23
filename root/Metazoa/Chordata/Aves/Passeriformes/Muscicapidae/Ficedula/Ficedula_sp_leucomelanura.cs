namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Ficedula;

/// <summary>
/// Species: Ficedula sp. 'leucomelanura'
/// NCBI TaxId: 427700
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ficedula_sp_leucomelanura : Ficedula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ficedula sp. 'leucomelanura'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ficedula_sp_leucomelanura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 427700;
}
