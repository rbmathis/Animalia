using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Ericabatrachus;

/// <summary>
/// Abstract class for Ericabatrachus (genus).
/// NCBI TaxId: 685131
/// </summary>
public abstract class Ericabatrachus : Pyxicephalidae, IEricabatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ericabatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 685131;

    /// <inheritdoc />
    public virtual string GenusName => "Ericabatrachus";

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
