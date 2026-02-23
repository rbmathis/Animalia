using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Microdous;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Odontobutidae.Microdous.unclassified_Microdous;

/// <summary>
/// Abstract class for unclassified Microdous (no rank).
/// NCBI TaxId: 3132936
/// </summary>
public abstract class unclassified_Microdous : Microdous, Iunclassified_Microdous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microdous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3132936;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microdous";
}
