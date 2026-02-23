using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Boops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Boops.unclassified_Boops;

/// <summary>
/// Abstract class for unclassified Boops (no rank).
/// NCBI TaxId: 3081707
/// </summary>
public abstract class unclassified_Boops : Boops, Iunclassified_Boops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3081707;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boops";
}
