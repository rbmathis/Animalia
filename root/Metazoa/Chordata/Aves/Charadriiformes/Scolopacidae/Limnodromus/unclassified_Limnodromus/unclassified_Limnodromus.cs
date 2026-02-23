using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Limnodromus;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Limnodromus.unclassified_Limnodromus;

/// <summary>
/// Abstract class for unclassified Limnodromus (no rank).
/// NCBI TaxId: 2640787
/// </summary>
public abstract class unclassified_Limnodromus : Limnodromus, Iunclassified_Limnodromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Limnodromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640787;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Limnodromus";
}
