namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Brycinus;

/// <summary>
/// Species: Brycinus sp. 'parvus'
/// NCBI TaxId: 1881100
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brycinus_sp_parvus : Brycinus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brycinus sp. 'parvus'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brycinus_sp_parvus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1881100;
}
