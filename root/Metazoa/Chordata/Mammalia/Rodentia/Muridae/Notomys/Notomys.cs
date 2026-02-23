using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Notomys;

/// <summary>
/// Abstract class for Notomys (genus).
/// NCBI TaxId: 184395
/// </summary>
public abstract class Notomys : Muridae, INotomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 184395;

    /// <inheritdoc />
    public virtual string GenusName => "Notomys";

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
