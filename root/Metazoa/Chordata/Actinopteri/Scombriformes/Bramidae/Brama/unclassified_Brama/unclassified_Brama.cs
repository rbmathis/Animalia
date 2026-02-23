using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Brama;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Scombriformes.Bramidae.Brama.unclassified_Brama;

/// <summary>
/// Abstract class for unclassified Brama (no rank).
/// NCBI TaxId: 2645083
/// </summary>
public abstract class unclassified_Brama : Brama, Iunclassified_Brama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645083;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brama";
}
