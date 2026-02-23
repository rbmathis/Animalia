using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Stanulus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Stanulus.unclassified_Stanulus;

/// <summary>
/// Abstract class for unclassified Stanulus (no rank).
/// NCBI TaxId: 2643736
/// </summary>
public abstract class unclassified_Stanulus : Stanulus, Iunclassified_Stanulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stanulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643736;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stanulus";
}
