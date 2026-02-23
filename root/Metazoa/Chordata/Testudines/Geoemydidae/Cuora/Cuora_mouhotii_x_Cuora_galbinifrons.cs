namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Cuora;

/// <summary>
/// Species: Cuora mouhotii x Cuora galbinifrons
/// NCBI TaxId: 306551
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cuora_mouhotii_x_Cuora_galbinifrons : Cuora
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cuora mouhotii x Cuora galbinifrons";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cuora_mouhotii_x_Cuora_galbinifrons";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 306551;
}
