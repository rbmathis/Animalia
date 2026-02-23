namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Rasbora;

/// <summary>
/// Species: Rasbora sp. 'Thailand'
/// NCBI TaxId: 857663
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rasbora_sp_Thailand : Rasbora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rasbora sp. 'Thailand'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rasbora_sp_Thailand";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 857663;
}
