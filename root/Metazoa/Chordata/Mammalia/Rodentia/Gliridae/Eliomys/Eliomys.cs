using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Eliomys;

/// <summary>
/// Abstract class for Eliomys (genus).
/// NCBI TaxId: 53276
/// </summary>
public abstract class Eliomys : Gliridae, IEliomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eliomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 53276;

    /// <inheritdoc />
    public virtual string GenusName => "Eliomys";

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
