using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.Poromitra;

/// <summary>
/// Abstract class for Poromitra (genus).
/// NCBI TaxId: 88707
/// </summary>
public abstract class Poromitra : Melamphaidae, IPoromitra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poromitra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88707;

    /// <inheritdoc />
    public virtual string GenusName => "Poromitra";

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
