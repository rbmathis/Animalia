using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Diprotodontia.Vombatidae.Lasiorhinus;

/// <summary>
/// Abstract class for Lasiorhinus (genus).
/// NCBI TaxId: 30666
/// </summary>
public abstract class Lasiorhinus : Vombatidae, ILasiorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lasiorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30666;

    /// <inheritdoc />
    public virtual string GenusName => "Lasiorhinus";

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
