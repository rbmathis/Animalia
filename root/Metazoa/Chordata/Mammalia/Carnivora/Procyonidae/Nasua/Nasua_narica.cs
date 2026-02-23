namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasua;

/// <summary>
/// Species: Nasua narica
/// NCBI TaxId: 352831
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nasua_narica : Nasua
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nasua narica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nasua_narica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 352831;
}
