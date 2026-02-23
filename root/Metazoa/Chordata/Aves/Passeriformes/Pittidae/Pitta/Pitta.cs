using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pittidae.Pitta;

/// <summary>
/// Abstract class for Pitta (genus).
/// NCBI TaxId: 9162
/// </summary>
public abstract class Pitta : Pittidae, IPitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9162;

    /// <inheritdoc />
    public virtual string GenusName => "Pitta";

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
