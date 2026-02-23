using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Phonipara;

/// <summary>
/// Abstract class for Phonipara (genus).
/// NCBI TaxId: 3150844
/// </summary>
public abstract class Phonipara : Thraupidae, IPhonipara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phonipara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150844;

    /// <inheritdoc />
    public virtual string GenusName => "Phonipara";

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
