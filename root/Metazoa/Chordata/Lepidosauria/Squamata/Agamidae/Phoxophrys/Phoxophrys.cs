using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Phoxophrys;

/// <summary>
/// Abstract class for Phoxophrys (genus).
/// NCBI TaxId: 103706
/// </summary>
public abstract class Phoxophrys : Agamidae, IPhoxophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoxophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103706;

    /// <inheritdoc />
    public virtual string GenusName => "Phoxophrys";

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
