using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Glauconycteris;

/// <summary>
/// Abstract class for Glauconycteris (genus).
/// NCBI TaxId: 909366
/// </summary>
public abstract class Glauconycteris : Vespertilionidae, IGlauconycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glauconycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 909366;

    /// <inheritdoc />
    public virtual string GenusName => "Glauconycteris";

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
