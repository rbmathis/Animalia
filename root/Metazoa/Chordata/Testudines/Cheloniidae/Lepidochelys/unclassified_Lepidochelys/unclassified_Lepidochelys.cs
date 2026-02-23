using AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Lepidochelys;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Cheloniidae.Lepidochelys.unclassified_Lepidochelys;

/// <summary>
/// Abstract class for unclassified Lepidochelys (no rank).
/// NCBI TaxId: 2619719
/// </summary>
public abstract class unclassified_Lepidochelys : Lepidochelys, Iunclassified_Lepidochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619719;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidochelys";
}
