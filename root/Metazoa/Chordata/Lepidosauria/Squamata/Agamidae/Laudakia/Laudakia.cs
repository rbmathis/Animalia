using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Laudakia;

/// <summary>
/// Abstract class for Laudakia (genus).
/// NCBI TaxId: 52203
/// </summary>
public abstract class Laudakia : Agamidae, ILaudakia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laudakia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52203;

    /// <inheritdoc />
    public virtual string GenusName => "Laudakia";

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
