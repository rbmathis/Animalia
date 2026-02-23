using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Cichladusa;

/// <summary>
/// Abstract class for Cichladusa (genus).
/// NCBI TaxId: 757455
/// </summary>
public abstract class Cichladusa : Muscicapidae, ICichladusa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cichladusa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 757455;

    /// <inheritdoc />
    public virtual string GenusName => "Cichladusa";

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
