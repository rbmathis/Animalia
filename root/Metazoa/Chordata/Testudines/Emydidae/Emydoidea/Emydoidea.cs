using AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Emydoidea;

/// <summary>
/// Abstract class for Emydoidea (genus).
/// NCBI TaxId: 85612
/// </summary>
public abstract class Emydoidea : Emydidae, IEmydoidea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emydoidea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 85612;

    /// <inheritdoc />
    public virtual string GenusName => "Emydoidea";

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
