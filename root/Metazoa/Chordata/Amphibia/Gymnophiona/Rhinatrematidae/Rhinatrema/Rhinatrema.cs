using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Rhinatrematidae.Rhinatrema;

/// <summary>
/// Abstract class for Rhinatrema (genus).
/// NCBI TaxId: 194407
/// </summary>
public abstract class Rhinatrema : Rhinatrematidae, IRhinatrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinatrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 194407;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinatrema";

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
