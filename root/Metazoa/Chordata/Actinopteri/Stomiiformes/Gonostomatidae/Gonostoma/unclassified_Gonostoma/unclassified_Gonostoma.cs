using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Gonostoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Gonostoma.unclassified_Gonostoma;

/// <summary>
/// Abstract class for unclassified Gonostoma (no rank).
/// NCBI TaxId: 2637956
/// </summary>
public abstract class unclassified_Gonostoma : Gonostoma, Iunclassified_Gonostoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gonostoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637956;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gonostoma";
}
