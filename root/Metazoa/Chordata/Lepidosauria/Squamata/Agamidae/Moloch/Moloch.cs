using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Moloch;

/// <summary>
/// Abstract class for Moloch (genus).
/// NCBI TaxId: 52197
/// </summary>
public abstract class Moloch : Agamidae, IMoloch
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Moloch";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52197;

    /// <inheritdoc />
    public virtual string GenusName => "Moloch";

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
