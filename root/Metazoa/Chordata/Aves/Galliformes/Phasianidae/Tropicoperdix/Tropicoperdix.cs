using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tropicoperdix;

/// <summary>
/// Abstract class for Tropicoperdix (genus).
/// NCBI TaxId: 1717230
/// </summary>
public abstract class Tropicoperdix : Phasianidae, ITropicoperdix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropicoperdix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1717230;

    /// <inheritdoc />
    public virtual string GenusName => "Tropicoperdix";

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
