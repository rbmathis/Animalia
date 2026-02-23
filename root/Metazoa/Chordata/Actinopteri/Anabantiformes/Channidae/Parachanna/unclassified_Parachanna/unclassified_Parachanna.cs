using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Parachanna;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Channidae.Parachanna.unclassified_Parachanna;

/// <summary>
/// Abstract class for unclassified Parachanna (no rank).
/// NCBI TaxId: 2647504
/// </summary>
public abstract class unclassified_Parachanna : Parachanna, Iunclassified_Parachanna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Parachanna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647504;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Parachanna";
}
