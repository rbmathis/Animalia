using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Parasciurus;

/// <summary>
/// Abstract class for Parasciurus (genus).
/// NCBI TaxId: 2895725
/// </summary>
public abstract class Parasciurus : Sciuridae, IParasciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parasciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2895725;

    /// <inheritdoc />
    public virtual string GenusName => "Parasciurus";

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
