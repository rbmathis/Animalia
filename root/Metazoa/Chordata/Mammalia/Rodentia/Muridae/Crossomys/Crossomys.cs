using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Crossomys;

/// <summary>
/// Abstract class for Crossomys (genus).
/// NCBI TaxId: 442569
/// </summary>
public abstract class Crossomys : Muridae, ICrossomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442569;

    /// <inheritdoc />
    public virtual string GenusName => "Crossomys";

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
