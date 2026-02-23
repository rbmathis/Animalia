using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Mugil;

/// <summary>
/// Abstract class for Mugil (genus).
/// NCBI TaxId: 8190
/// </summary>
public abstract class Mugil : Mugilidae, IMugil
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mugil";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8190;

    /// <inheritdoc />
    public virtual string GenusName => "Mugil";

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
