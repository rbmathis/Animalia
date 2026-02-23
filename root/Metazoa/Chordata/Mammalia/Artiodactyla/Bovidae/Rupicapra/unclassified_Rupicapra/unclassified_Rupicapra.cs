using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Rupicapra;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Rupicapra.unclassified_Rupicapra;

/// <summary>
/// Abstract class for unclassified Rupicapra (no rank).
/// NCBI TaxId: 2647444
/// </summary>
public abstract class unclassified_Rupicapra : Rupicapra, Iunclassified_Rupicapra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rupicapra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647444;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rupicapra";
}
