namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Kuhliidae.Kuhlia;

/// <summary>
/// Species: Kuhlia sauvagii
/// NCBI TaxId: 1155420
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kuhlia_sauvagii : Kuhlia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kuhlia sauvagii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kuhlia_sauvagii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1155420;
}
