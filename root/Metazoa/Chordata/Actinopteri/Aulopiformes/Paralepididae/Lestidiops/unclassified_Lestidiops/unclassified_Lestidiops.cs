using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestidiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Paralepididae.Lestidiops.unclassified_Lestidiops;

/// <summary>
/// Abstract class for unclassified Lestidiops (no rank).
/// NCBI TaxId: 3230570
/// </summary>
public abstract class unclassified_Lestidiops : Lestidiops, Iunclassified_Lestidiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lestidiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3230570;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lestidiops";
}
