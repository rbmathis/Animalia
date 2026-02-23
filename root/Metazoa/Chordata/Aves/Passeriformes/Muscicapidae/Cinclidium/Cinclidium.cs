using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cinclidium;

/// <summary>
/// Abstract class for Cinclidium (genus).
/// NCBI TaxId: 757457
/// </summary>
public abstract class Cinclidium : Muscicapidae, ICinclidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinclidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 757457;

    /// <inheritdoc />
    public virtual string GenusName => "Cinclidium";

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
