using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Dinopium;

/// <summary>
/// Abstract class for Dinopium (genus).
/// NCBI TaxId: 367956
/// </summary>
public abstract class Dinopium : Picidae, IDinopium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dinopium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 367956;

    /// <inheritdoc />
    public virtual string GenusName => "Dinopium";

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
