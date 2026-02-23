using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Trachinotus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Trachinotus.unclassified_Trachinotus;

/// <summary>
/// Abstract class for unclassified Trachinotus (no rank).
/// NCBI TaxId: 2639529
/// </summary>
public abstract class unclassified_Trachinotus : Trachinotus, Iunclassified_Trachinotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachinotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639529;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachinotus";
}
