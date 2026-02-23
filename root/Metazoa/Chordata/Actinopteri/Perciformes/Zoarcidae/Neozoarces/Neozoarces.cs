using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Neozoarces;

/// <summary>
/// Abstract class for Neozoarces (genus).
/// NCBI TaxId: 641284
/// </summary>
public abstract class Neozoarces : Zoarcidae, INeozoarces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neozoarces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 641284;

    /// <inheritdoc />
    public virtual string GenusName => "Neozoarces";

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
