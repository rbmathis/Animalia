using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis;

/// <summary>
/// Abstract class for Sylviidae incertae sedis (no rank).
/// NCBI TaxId: 2927229
/// </summary>
public abstract class Sylviidae_incertae_sedis : Sylviidae, ISylviidae_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sylviidae incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2927229;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Sylviidae_incertae_sedis";
}
