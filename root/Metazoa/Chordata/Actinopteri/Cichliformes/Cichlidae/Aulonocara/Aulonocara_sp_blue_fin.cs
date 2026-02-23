namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Aulonocara;

/// <summary>
/// Species: Aulonocara sp. 'blue fin'
/// NCBI TaxId: 702367
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aulonocara_sp_blue_fin : Aulonocara
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aulonocara sp. 'blue fin'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aulonocara_sp_blue_fin";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 702367;
}
