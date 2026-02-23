using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Myosciurus;

/// <summary>
/// Abstract class for Myosciurus (genus).
/// NCBI TaxId: 226686
/// </summary>
public abstract class Myosciurus : Sciuridae, IMyosciurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myosciurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226686;

    /// <inheritdoc />
    public virtual string GenusName => "Myosciurus";

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
