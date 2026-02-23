using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Namibornis;

/// <summary>
/// Abstract class for Namibornis (genus).
/// NCBI TaxId: 315545
/// </summary>
public abstract class Namibornis : Muscicapidae, INamibornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Namibornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315545;

    /// <inheritdoc />
    public virtual string GenusName => "Namibornis";

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
