using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Papagomys;

/// <summary>
/// Abstract class for Papagomys (genus).
/// NCBI TaxId: 2716771
/// </summary>
public abstract class Papagomys : Muridae, IPapagomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Papagomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2716771;

    /// <inheritdoc />
    public virtual string GenusName => "Papagomys";

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
