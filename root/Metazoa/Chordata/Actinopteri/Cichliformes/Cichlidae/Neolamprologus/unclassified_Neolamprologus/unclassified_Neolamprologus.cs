using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Neolamprologus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Neolamprologus.unclassified_Neolamprologus;

/// <summary>
/// Abstract class for unclassified Neolamprologus (no rank).
/// NCBI TaxId: 2641500
/// </summary>
public abstract class unclassified_Neolamprologus : Neolamprologus, Iunclassified_Neolamprologus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neolamprologus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641500;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neolamprologus";
}
