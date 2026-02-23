using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Ammoperdix;

/// <summary>
/// Abstract class for Ammoperdix (genus).
/// NCBI TaxId: 388989
/// </summary>
public abstract class Ammoperdix : Phasianidae, IAmmoperdix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ammoperdix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 388989;

    /// <inheritdoc />
    public virtual string GenusName => "Ammoperdix";

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
