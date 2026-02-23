using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stylephoriformes.Stylephoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stylephoriformes.Stylephoridae.Stylephorus;

/// <summary>
/// Abstract class for Stylephorus (genus).
/// NCBI TaxId: 409995
/// </summary>
public abstract class Stylephorus : Stylephoridae, IStylephorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stylephorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 409995;

    /// <inheritdoc />
    public virtual string GenusName => "Stylephorus";

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
