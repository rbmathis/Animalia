using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Andinoacara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Andinoacara.unclassified_Andinoacara;

/// <summary>
/// Abstract class for unclassified Andinoacara (no rank).
/// NCBI TaxId: 2640026
/// </summary>
public abstract class unclassified_Andinoacara : Andinoacara, Iunclassified_Andinoacara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Andinoacara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640026;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Andinoacara";
}
