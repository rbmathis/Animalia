using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Scolopacidae.Limnodromus;

/// <summary>
/// Abstract class for Limnodromus (genus).
/// NCBI TaxId: 161677
/// </summary>
public abstract class Limnodromus : Scolopacidae, ILimnodromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Limnodromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161677;

    /// <inheritdoc />
    public virtual string GenusName => "Limnodromus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
