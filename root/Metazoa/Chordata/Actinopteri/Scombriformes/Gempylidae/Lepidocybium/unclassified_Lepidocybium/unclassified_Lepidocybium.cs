using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Lepidocybium;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Gempylidae.Lepidocybium.unclassified_Lepidocybium;

/// <summary>
/// Abstract class for unclassified Lepidocybium (no rank).
/// NCBI TaxId: 3031677
/// </summary>
public abstract class unclassified_Lepidocybium : Lepidocybium, Iunclassified_Lepidocybium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidocybium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3031677;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidocybium";
}
