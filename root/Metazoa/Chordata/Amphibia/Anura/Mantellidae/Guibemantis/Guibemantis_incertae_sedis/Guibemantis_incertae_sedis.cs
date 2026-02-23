using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Guibemantis;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Mantellidae.Guibemantis.Guibemantis_incertae_sedis;

/// <summary>
/// Abstract class for Guibemantis incertae sedis (no rank).
/// NCBI TaxId: 3004341
/// </summary>
public abstract class Guibemantis_incertae_sedis : Guibemantis, IGuibemantis_incertae_sedis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guibemantis incertae sedis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3004341;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Guibemantis_incertae_sedis";
}
