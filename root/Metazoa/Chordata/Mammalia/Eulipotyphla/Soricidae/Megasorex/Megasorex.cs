using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Megasorex;

/// <summary>
/// Abstract class for Megasorex (genus).
/// NCBI TaxId: 268774
/// </summary>
public abstract class Megasorex : Soricidae, IMegasorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megasorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 268774;

    /// <inheritdoc />
    public virtual string GenusName => "Megasorex";

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
