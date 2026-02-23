using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vireonidae.Hylophilus;

/// <summary>
/// Abstract class for Hylophilus (genus).
/// NCBI TaxId: 158056
/// </summary>
public abstract class Hylophilus : Vireonidae, IHylophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158056;

    /// <inheritdoc />
    public virtual string GenusName => "Hylophilus";

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
