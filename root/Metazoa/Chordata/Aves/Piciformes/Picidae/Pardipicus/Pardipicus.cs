using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Pardipicus;

/// <summary>
/// Abstract class for Pardipicus (genus).
/// NCBI TaxId: 3150815
/// </summary>
public abstract class Pardipicus : Picidae, IPardipicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pardipicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150815;

    /// <inheritdoc />
    public virtual string GenusName => "Pardipicus";

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
