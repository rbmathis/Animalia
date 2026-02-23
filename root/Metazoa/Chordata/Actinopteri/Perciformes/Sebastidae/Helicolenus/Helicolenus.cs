using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Sebastidae.Helicolenus;

/// <summary>
/// Abstract class for Helicolenus (genus).
/// NCBI TaxId: 143343
/// </summary>
public abstract class Helicolenus : Sebastidae, IHelicolenus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Helicolenus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143343;

    /// <inheritdoc />
    public virtual string GenusName => "Helicolenus";

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
