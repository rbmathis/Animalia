using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salaria;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Salaria.unclassified_Salaria;

/// <summary>
/// Abstract class for unclassified Salaria (no rank).
/// NCBI TaxId: 2649492
/// </summary>
public abstract class unclassified_Salaria : Salaria, Iunclassified_Salaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Salaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649492;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Salaria";
}
