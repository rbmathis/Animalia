using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Cremnomys;

/// <summary>
/// Abstract class for Cremnomys (genus).
/// NCBI TaxId: 333389
/// </summary>
public abstract class Cremnomys : Muridae, ICremnomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cremnomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 333389;

    /// <inheritdoc />
    public virtual string GenusName => "Cremnomys";

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
