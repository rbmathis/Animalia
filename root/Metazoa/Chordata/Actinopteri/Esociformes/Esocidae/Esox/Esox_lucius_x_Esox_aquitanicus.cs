namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Esociformes.Esocidae.Esox;

/// <summary>
/// Species: Esox lucius x Esox aquitanicus
/// NCBI TaxId: 2573018
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Esox_lucius_x_Esox_aquitanicus : Esox
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Esox lucius x Esox aquitanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Esox_lucius_x_Esox_aquitanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2573018;
}
