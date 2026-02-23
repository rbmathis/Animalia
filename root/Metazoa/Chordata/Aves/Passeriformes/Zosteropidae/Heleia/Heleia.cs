using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Zosteropidae.Heleia;

/// <summary>
/// Abstract class for Heleia (genus).
/// NCBI TaxId: 634298
/// </summary>
public abstract class Heleia : Zosteropidae, IHeleia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heleia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 634298;

    /// <inheritdoc />
    public virtual string GenusName => "Heleia";

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
