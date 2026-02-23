using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Synoicus;

/// <summary>
/// Abstract class for Synoicus (genus).
/// NCBI TaxId: 1592579
/// </summary>
public abstract class Synoicus : Phasianidae, ISynoicus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synoicus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1592579;

    /// <inheritdoc />
    public virtual string GenusName => "Synoicus";

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
