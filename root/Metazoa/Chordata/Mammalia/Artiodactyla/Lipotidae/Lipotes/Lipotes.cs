using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Lipotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Lipotidae.Lipotes;

/// <summary>
/// Abstract class for Lipotes (genus).
/// NCBI TaxId: 118796
/// </summary>
public abstract class Lipotes : Lipotidae, ILipotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118796;

    /// <inheritdoc />
    public virtual string GenusName => "Lipotes";

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
