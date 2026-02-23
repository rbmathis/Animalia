using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Elachocharax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Elachocharax.unclassified_Elachocharax;

/// <summary>
/// Abstract class for unclassified Elachocharax (no rank).
/// NCBI TaxId: 2643897
/// </summary>
public abstract class unclassified_Elachocharax : Elachocharax, Iunclassified_Elachocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Elachocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2643897;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Elachocharax";
}
