using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Salmo.unclassified_Salmo;

/// <summary>
/// Abstract class for unclassified Salmo (no rank).
/// NCBI TaxId: 2629501
/// </summary>
public abstract class unclassified_Salmo : Salmo, Iunclassified_Salmo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salmo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629501;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salmo";
}
