using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Diplophidae.Diplophos;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Diplophidae.Diplophos.unclassified_Diplophos;

/// <summary>
/// Abstract class for unclassified Diplophos (no rank).
/// NCBI TaxId: 2685257
/// </summary>
public abstract class unclassified_Diplophos : Diplophos, Iunclassified_Diplophos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Diplophos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685257;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Diplophos";
}
