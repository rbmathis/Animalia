using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Monotocheirodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Monotocheirodon.unclassified_Monotocheirodon;

/// <summary>
/// Abstract class for unclassified Monotocheirodon (no rank).
/// NCBI TaxId: 2645689
/// </summary>
public abstract class unclassified_Monotocheirodon : Monotocheirodon, Iunclassified_Monotocheirodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Monotocheirodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645689;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Monotocheirodon";
}
