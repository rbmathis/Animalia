using AnimalKingdom.root.Metazoa.Chordata.Tyrannosauridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Tyrannosauridae.Tyrannosaurus;

/// <summary>
/// Abstract class for Tyrannosaurus (genus).
/// NCBI TaxId: 436494
/// </summary>
public abstract class Tyrannosaurus : Tyrannosauridae, ITyrannosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyrannosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 436494;

    /// <inheritdoc />
    public virtual string GenusName => "Tyrannosaurus";

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
