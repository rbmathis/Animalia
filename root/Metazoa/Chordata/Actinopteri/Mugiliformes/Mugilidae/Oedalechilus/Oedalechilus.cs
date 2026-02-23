using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Oedalechilus;

/// <summary>
/// Abstract class for Oedalechilus (genus).
/// NCBI TaxId: 48195
/// </summary>
public abstract class Oedalechilus : Mugilidae, IOedalechilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oedalechilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48195;

    /// <inheritdoc />
    public virtual string GenusName => "Oedalechilus";

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
