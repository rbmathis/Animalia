using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Mokopirirakau;

/// <summary>
/// Abstract class for Mokopirirakau (genus).
/// NCBI TaxId: 1165298
/// </summary>
public abstract class Mokopirirakau : Diplodactylidae, IMokopirirakau
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mokopirirakau";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1165298;

    /// <inheritdoc />
    public virtual string GenusName => "Mokopirirakau";

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
