using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Monophyllus;

/// <summary>
/// Abstract class for Monophyllus (genus).
/// NCBI TaxId: 148046
/// </summary>
public abstract class Monophyllus : Phyllostomidae, IMonophyllus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monophyllus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148046;

    /// <inheritdoc />
    public virtual string GenusName => "Monophyllus";

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
