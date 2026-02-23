using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lepidiolamprologus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lepidiolamprologus.unclassified_Lepidiolamprologus;

/// <summary>
/// Abstract class for unclassified Lepidiolamprologus (no rank).
/// NCBI TaxId: 2626348
/// </summary>
public abstract class unclassified_Lepidiolamprologus : Lepidiolamprologus, Iunclassified_Lepidiolamprologus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lepidiolamprologus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626348;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lepidiolamprologus";
}
