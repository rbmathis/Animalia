using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Laodracon;

/// <summary>
/// Abstract class for Laodracon (genus).
/// NCBI TaxId: 3110336
/// </summary>
public abstract class Laodracon : Agamidae, ILaodracon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laodracon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3110336;

    /// <inheritdoc />
    public virtual string GenusName => "Laodracon";

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
