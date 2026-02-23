using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Micaelamys;

/// <summary>
/// Abstract class for Micaelamys (genus).
/// NCBI TaxId: 472706
/// </summary>
public abstract class Micaelamys : Muridae, IMicaelamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Micaelamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472706;

    /// <inheritdoc />
    public virtual string GenusName => "Micaelamys";

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
