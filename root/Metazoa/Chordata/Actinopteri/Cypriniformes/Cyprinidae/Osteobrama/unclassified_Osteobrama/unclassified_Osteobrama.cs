using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Osteobrama;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Osteobrama.unclassified_Osteobrama;

/// <summary>
/// Abstract class for unclassified Osteobrama (no rank).
/// NCBI TaxId: 2621991
/// </summary>
public abstract class unclassified_Osteobrama : Osteobrama, Iunclassified_Osteobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Osteobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621991;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Osteobrama";
}
