using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Margaroperdix;

/// <summary>
/// Abstract class for Margaroperdix (genus).
/// NCBI TaxId: 57750
/// </summary>
public abstract class Margaroperdix : Phasianidae, IMargaroperdix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Margaroperdix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57750;

    /// <inheritdoc />
    public virtual string GenusName => "Margaroperdix";

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
