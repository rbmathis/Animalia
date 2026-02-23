using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Bathyergidae.Heterocephalus;

/// <summary>
/// Abstract class for Heterocephalus (genus).
/// NCBI TaxId: 10180
/// </summary>
public abstract class Heterocephalus : Bathyergidae, IHeterocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heterocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10180;

    /// <inheritdoc />
    public virtual string GenusName => "Heterocephalus";

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
