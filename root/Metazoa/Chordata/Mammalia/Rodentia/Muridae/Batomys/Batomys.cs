using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Batomys;

/// <summary>
/// Abstract class for Batomys (genus).
/// NCBI TaxId: 234627
/// </summary>
public abstract class Batomys : Muridae, IBatomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 234627;

    /// <inheritdoc />
    public virtual string GenusName => "Batomys";

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
