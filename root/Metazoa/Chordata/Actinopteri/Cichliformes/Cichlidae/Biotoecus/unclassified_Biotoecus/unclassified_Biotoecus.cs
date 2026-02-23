using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Biotoecus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Biotoecus.unclassified_Biotoecus;

/// <summary>
/// Abstract class for unclassified Biotoecus (no rank).
/// NCBI TaxId: 2628838
/// </summary>
public abstract class unclassified_Biotoecus : Biotoecus, Iunclassified_Biotoecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Biotoecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628838;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Biotoecus";
}
