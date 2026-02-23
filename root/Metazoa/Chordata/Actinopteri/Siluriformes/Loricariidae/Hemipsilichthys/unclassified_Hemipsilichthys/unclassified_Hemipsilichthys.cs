using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemipsilichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemipsilichthys.unclassified_Hemipsilichthys;

/// <summary>
/// Abstract class for unclassified Hemipsilichthys (no rank).
/// NCBI TaxId: 2644496
/// </summary>
public abstract class unclassified_Hemipsilichthys : Hemipsilichthys, Iunclassified_Hemipsilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemipsilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644496;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemipsilichthys";
}
