using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Phrynocephalus;

/// <summary>
/// Abstract class for Phrynocephalus (genus).
/// NCBI TaxId: 52205
/// </summary>
public abstract class Phrynocephalus : Agamidae, IPhrynocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52205;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynocephalus";

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
