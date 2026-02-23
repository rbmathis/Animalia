using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Ametrida;

/// <summary>
/// Abstract class for Ametrida (genus).
/// NCBI TaxId: 148022
/// </summary>
public abstract class Ametrida : Phyllostomidae, IAmetrida
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ametrida";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148022;

    /// <inheritdoc />
    public virtual string GenusName => "Ametrida";

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
