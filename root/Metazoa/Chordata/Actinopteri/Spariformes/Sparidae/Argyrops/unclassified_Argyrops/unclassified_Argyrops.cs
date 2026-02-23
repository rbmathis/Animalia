using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Argyrops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Argyrops.unclassified_Argyrops;

/// <summary>
/// Abstract class for unclassified Argyrops (no rank).
/// NCBI TaxId: 2618824
/// </summary>
public abstract class unclassified_Argyrops : Argyrops, Iunclassified_Argyrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Argyrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618824;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Argyrops";
}
