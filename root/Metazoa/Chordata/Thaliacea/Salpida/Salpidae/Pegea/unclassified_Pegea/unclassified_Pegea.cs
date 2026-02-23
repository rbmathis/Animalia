using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Pegea;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Salpida.Salpidae.Pegea.unclassified_Pegea;

/// <summary>
/// Abstract class for unclassified Pegea (no rank).
/// NCBI TaxId: 3019175
/// </summary>
public abstract class unclassified_Pegea : Pegea, Iunclassified_Pegea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pegea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3019175;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pegea";
}
