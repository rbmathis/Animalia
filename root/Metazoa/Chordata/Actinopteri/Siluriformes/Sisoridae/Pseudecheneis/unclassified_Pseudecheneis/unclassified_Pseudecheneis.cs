using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudecheneis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Sisoridae.Pseudecheneis.unclassified_Pseudecheneis;

/// <summary>
/// Abstract class for unclassified Pseudecheneis (no rank).
/// NCBI TaxId: 2647015
/// </summary>
public abstract class unclassified_Pseudecheneis : Pseudecheneis, Iunclassified_Pseudecheneis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudecheneis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647015;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudecheneis";
}
