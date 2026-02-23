using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Aquila;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Aquila.unclassified_Aquila;

/// <summary>
/// Abstract class for unclassified Aquila (no rank).
/// NCBI TaxId: 2676976
/// </summary>
public abstract class unclassified_Aquila : Aquila, Iunclassified_Aquila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aquila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676976;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aquila";
}
