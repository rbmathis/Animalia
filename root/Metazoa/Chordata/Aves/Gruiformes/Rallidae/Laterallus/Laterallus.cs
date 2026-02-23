using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Laterallus;

/// <summary>
/// Abstract class for Laterallus (genus).
/// NCBI TaxId: 54362
/// </summary>
public abstract class Laterallus : Rallidae, ILaterallus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laterallus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54362;

    /// <inheritdoc />
    public virtual string GenusName => "Laterallus";

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
