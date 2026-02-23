using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Amblyceps;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amblycipitidae.Amblyceps.unclassified_Amblyceps;

/// <summary>
/// Abstract class for unclassified Amblyceps (no rank).
/// NCBI TaxId: 2618589
/// </summary>
public abstract class unclassified_Amblyceps : Amblyceps, Iunclassified_Amblyceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amblyceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618589;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amblyceps";
}
