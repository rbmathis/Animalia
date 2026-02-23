using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Marmota;

/// <summary>
/// Abstract class for Marmota (genus).
/// NCBI TaxId: 9992
/// </summary>
public abstract class Marmota : Sciuridae, IMarmota
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marmota";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9992;

    /// <inheritdoc />
    public virtual string GenusName => "Marmota";

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
