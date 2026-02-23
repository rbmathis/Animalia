using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Xenoperdix;

/// <summary>
/// Abstract class for Xenoperdix (genus).
/// NCBI TaxId: 338141
/// </summary>
public abstract class Xenoperdix : Phasianidae, IXenoperdix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenoperdix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 338141;

    /// <inheritdoc />
    public virtual string GenusName => "Xenoperdix";

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
