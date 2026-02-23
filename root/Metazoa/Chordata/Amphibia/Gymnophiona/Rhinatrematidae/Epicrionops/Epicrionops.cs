using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae.Epicrionops;

/// <summary>
/// Abstract class for Epicrionops (genus).
/// NCBI TaxId: 43480
/// </summary>
public abstract class Epicrionops : Rhinatrematidae, IEpicrionops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Epicrionops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43480;

    /// <inheritdoc />
    public virtual string GenusName => "Epicrionops";

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
