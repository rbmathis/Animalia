using AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Chelydridae.Macrochelys;

/// <summary>
/// Abstract class for Macrochelys (genus).
/// NCBI TaxId: 571337
/// </summary>
public abstract class Macrochelys : Chelydridae, IMacrochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 571337;

    /// <inheritdoc />
    public virtual string GenusName => "Macrochelys";

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
