namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Rhodinocichla;

/// <summary>
/// Species: Rhodinocichla rosea
/// NCBI TaxId: 58203
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhodinocichla_rosea : Rhodinocichla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhodinocichla rosea";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhodinocichla_rosea";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 58203;
}
