using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Bryconaethiops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Bryconaethiops.unclassified_Bryconaethiops;

/// <summary>
/// Abstract class for unclassified Bryconaethiops (no rank).
/// NCBI TaxId: 2647365
/// </summary>
public abstract class unclassified_Bryconaethiops : Bryconaethiops, Iunclassified_Bryconaethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Bryconaethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647365;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Bryconaethiops";
}
