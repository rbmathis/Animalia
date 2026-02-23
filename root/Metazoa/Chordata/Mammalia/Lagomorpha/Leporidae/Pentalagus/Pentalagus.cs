using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Pentalagus;

/// <summary>
/// Abstract class for Pentalagus (genus).
/// NCBI TaxId: 156446
/// </summary>
public abstract class Pentalagus : Leporidae, IPentalagus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pentalagus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156446;

    /// <inheritdoc />
    public virtual string GenusName => "Pentalagus";

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
