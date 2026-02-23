using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Philemon;

/// <summary>
/// Abstract class for Philemon (genus).
/// NCBI TaxId: 108843
/// </summary>
public abstract class Philemon : Meliphagidae, IPhilemon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philemon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 108843;

    /// <inheritdoc />
    public virtual string GenusName => "Philemon";

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
