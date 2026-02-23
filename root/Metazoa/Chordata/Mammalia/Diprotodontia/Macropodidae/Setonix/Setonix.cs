using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Macropodidae.Setonix;

/// <summary>
/// Abstract class for Setonix (genus).
/// NCBI TaxId: 30669
/// </summary>
public abstract class Setonix : Macropodidae, ISetonix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Setonix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30669;

    /// <inheritdoc />
    public virtual string GenusName => "Setonix";

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
