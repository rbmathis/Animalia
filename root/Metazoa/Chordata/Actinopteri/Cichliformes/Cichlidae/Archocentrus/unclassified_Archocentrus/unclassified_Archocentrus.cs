using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Archocentrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Archocentrus.unclassified_Archocentrus;

/// <summary>
/// Abstract class for unclassified Archocentrus (no rank).
/// NCBI TaxId: 2625339
/// </summary>
public abstract class unclassified_Archocentrus : Archocentrus, Iunclassified_Archocentrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Archocentrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625339;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Archocentrus";
}
