using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Draco;

/// <summary>
/// Abstract class for Draco (genus).
/// NCBI TaxId: 52211
/// </summary>
public abstract class Draco : Agamidae, IDraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Draco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52211;

    /// <inheritdoc />
    public virtual string GenusName => "Draco";

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
