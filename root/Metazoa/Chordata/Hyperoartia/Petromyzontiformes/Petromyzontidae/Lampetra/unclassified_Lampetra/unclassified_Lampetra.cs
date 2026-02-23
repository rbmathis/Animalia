using AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lampetra;

namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Lampetra.unclassified_Lampetra;

/// <summary>
/// Abstract class for unclassified Lampetra (no rank).
/// NCBI TaxId: 2626345
/// </summary>
public abstract class unclassified_Lampetra : Lampetra, Iunclassified_Lampetra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lampetra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626345;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lampetra";
}
