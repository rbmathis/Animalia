namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Ostraciidae.Ostracion;

/// <summary>
/// Species: Ostracion sp. IMCB-2002
/// NCBI TaxId: 188530
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ostracion_sp_IMCB_2002 : Ostracion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ostracion sp. IMCB-2002";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ostracion_sp_IMCB_2002";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 188530;
}
