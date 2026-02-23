using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Lepidocephalichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cobitidae.Lepidocephalichthys.unclassified_Lepidocephalichthys;

/// <summary>
/// Abstract class for unclassified Lepidocephalichthys (no rank).
/// NCBI TaxId: 2645003
/// </summary>
public abstract class unclassified_Lepidocephalichthys : Lepidocephalichthys, Iunclassified_Lepidocephalichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidocephalichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645003;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidocephalichthys";
}
