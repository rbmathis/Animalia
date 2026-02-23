using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Natalobatrachus;

/// <summary>
/// Abstract class for Natalobatrachus (genus).
/// NCBI TaxId: 143459
/// </summary>
public abstract class Natalobatrachus : Pyxicephalidae, INatalobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Natalobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143459;

    /// <inheritdoc />
    public virtual string GenusName => "Natalobatrachus";

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
