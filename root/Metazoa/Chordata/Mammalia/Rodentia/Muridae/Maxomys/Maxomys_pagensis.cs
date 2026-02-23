namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

/// <summary>
/// Species: Maxomys pagensis
/// NCBI TaxId: 907929
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Maxomys_pagensis : Maxomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Maxomys pagensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Maxomys_pagensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 907929;
}
