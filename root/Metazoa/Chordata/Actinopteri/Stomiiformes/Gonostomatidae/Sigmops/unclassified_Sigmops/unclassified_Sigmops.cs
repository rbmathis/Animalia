using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Sigmops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Gonostomatidae.Sigmops.unclassified_Sigmops;

/// <summary>
/// Abstract class for unclassified Sigmops (no rank).
/// NCBI TaxId: 2617562
/// </summary>
public abstract class unclassified_Sigmops : Sigmops, Iunclassified_Sigmops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sigmops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2617562;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sigmops";
}
