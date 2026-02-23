using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Hypogeomys;

/// <summary>
/// Abstract class for Hypogeomys (genus).
/// NCBI TaxId: 89378
/// </summary>
public abstract class Hypogeomys : Nesomyidae, IHypogeomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypogeomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89378;

    /// <inheritdoc />
    public virtual string GenusName => "Hypogeomys";

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
