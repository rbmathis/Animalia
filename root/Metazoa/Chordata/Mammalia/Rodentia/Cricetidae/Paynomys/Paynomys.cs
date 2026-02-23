using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Paynomys;

/// <summary>
/// Abstract class for Paynomys (genus).
/// NCBI TaxId: 2819014
/// </summary>
public abstract class Paynomys : Cricetidae, IPaynomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paynomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2819014;

    /// <inheritdoc />
    public virtual string GenusName => "Paynomys";

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
