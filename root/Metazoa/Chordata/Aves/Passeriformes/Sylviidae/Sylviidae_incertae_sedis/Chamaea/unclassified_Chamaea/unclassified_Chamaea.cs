using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis.Chamaea;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Sylviidae_incertae_sedis.Chamaea.unclassified_Chamaea;

/// <summary>
/// Abstract class for unclassified Chamaea (no rank).
/// NCBI TaxId: 2878734
/// </summary>
public abstract class unclassified_Chamaea : Chamaea, Iunclassified_Chamaea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chamaea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2878734;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chamaea";
}
