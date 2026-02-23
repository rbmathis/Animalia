using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Potamotyphlus;

/// <summary>
/// Abstract class for Potamotyphlus (genus).
/// NCBI TaxId: 3372752
/// </summary>
public abstract class Potamotyphlus : Typhlonectidae, IPotamotyphlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Potamotyphlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3372752;

    /// <inheritdoc />
    public virtual string GenusName => "Potamotyphlus";

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
