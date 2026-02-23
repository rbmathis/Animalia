using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Leiopicus;

/// <summary>
/// Abstract class for Leiopicus (genus).
/// NCBI TaxId: 1517828
/// </summary>
public abstract class Leiopicus : Picidae, ILeiopicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiopicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1517828;

    /// <inheritdoc />
    public virtual string GenusName => "Leiopicus";

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
