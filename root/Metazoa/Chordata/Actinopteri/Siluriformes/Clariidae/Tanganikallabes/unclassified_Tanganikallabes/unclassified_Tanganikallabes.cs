using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Tanganikallabes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Tanganikallabes.unclassified_Tanganikallabes;

/// <summary>
/// Abstract class for unclassified Tanganikallabes (no rank).
/// NCBI TaxId: 2637658
/// </summary>
public abstract class unclassified_Tanganikallabes : Tanganikallabes, Iunclassified_Tanganikallabes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tanganikallabes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637658;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tanganikallabes";
}
