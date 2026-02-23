using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Salinomys;

/// <summary>
/// Abstract class for Salinomys (genus).
/// NCBI TaxId: 119815
/// </summary>
public abstract class Salinomys : Cricetidae, ISalinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Salinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119815;

    /// <inheritdoc />
    public virtual string GenusName => "Salinomys";

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
