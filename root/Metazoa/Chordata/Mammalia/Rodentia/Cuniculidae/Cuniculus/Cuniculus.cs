using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cuniculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cuniculidae.Cuniculus;

/// <summary>
/// Abstract class for Cuniculus (genus).
/// NCBI TaxId: 723807
/// </summary>
public abstract class Cuniculus : Cuniculidae, ICuniculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cuniculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723807;

    /// <inheritdoc />
    public virtual string GenusName => "Cuniculus";

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
