using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Anisomys;

/// <summary>
/// Abstract class for Anisomys (genus).
/// NCBI TaxId: 332660
/// </summary>
public abstract class Anisomys : Muridae, IAnisomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anisomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 332660;

    /// <inheritdoc />
    public virtual string GenusName => "Anisomys";

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
