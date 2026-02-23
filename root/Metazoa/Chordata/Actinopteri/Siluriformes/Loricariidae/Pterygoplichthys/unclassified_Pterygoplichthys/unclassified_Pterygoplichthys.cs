using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pterygoplichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Pterygoplichthys.unclassified_Pterygoplichthys;

/// <summary>
/// Abstract class for unclassified Pterygoplichthys (no rank).
/// NCBI TaxId: 2644970
/// </summary>
public abstract class unclassified_Pterygoplichthys : Pterygoplichthys, Iunclassified_Pterygoplichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pterygoplichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644970;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pterygoplichthys";
}
