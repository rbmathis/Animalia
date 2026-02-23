namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Osteolaemus;

/// <summary>
/// Species: Osteolaemus sp. FAF-2012
/// NCBI TaxId: 1240978
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Osteolaemus_sp_FAF_2012 : Osteolaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Osteolaemus sp. FAF-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Osteolaemus_sp_FAF_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1240978;
}
