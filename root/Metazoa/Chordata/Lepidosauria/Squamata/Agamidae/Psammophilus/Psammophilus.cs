using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Psammophilus;

/// <summary>
/// Abstract class for Psammophilus (genus).
/// NCBI TaxId: 1545389
/// </summary>
public abstract class Psammophilus : Agamidae, IPsammophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psammophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545389;

    /// <inheritdoc />
    public virtual string GenusName => "Psammophilus";

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
