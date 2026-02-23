using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paradisaeidae.Phonygammus;

/// <summary>
/// Abstract class for Phonygammus (genus).
/// NCBI TaxId: 108845
/// </summary>
public abstract class Phonygammus : Paradisaeidae, IPhonygammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phonygammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108845;

    /// <inheritdoc />
    public virtual string GenusName => "Phonygammus";

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
