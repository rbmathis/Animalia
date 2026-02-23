using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Iguanodectes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Iguanodectidae.Iguanodectes.unclassified_Iguanodectes;

/// <summary>
/// Abstract class for unclassified Iguanodectes (no rank).
/// NCBI TaxId: 2625576
/// </summary>
public abstract class unclassified_Iguanodectes : Iguanodectes, Iunclassified_Iguanodectes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Iguanodectes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625576;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Iguanodectes";
}
