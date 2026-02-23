using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Helcogramma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Helcogramma.unclassified_Helcogramma;

/// <summary>
/// Abstract class for unclassified Helcogramma (no rank).
/// NCBI TaxId: 2638969
/// </summary>
public abstract class unclassified_Helcogramma : Helcogramma, Iunclassified_Helcogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Helcogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638969;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Helcogramma";
}
