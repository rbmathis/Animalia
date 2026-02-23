namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Bryconidae.Brycon;

/// <summary>
/// Species: Brycon sp. 'Bocas'
/// NCBI TaxId: 3239023
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Brycon_sp_Bocas : Brycon
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Brycon sp. 'Bocas'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Brycon_sp_Bocas";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3239023;
}
