using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Chimarrogale;

/// <summary>
/// Abstract class for Chimarrogale (genus).
/// NCBI TaxId: 62292
/// </summary>
public abstract class Chimarrogale : Soricidae, IChimarrogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chimarrogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62292;

    /// <inheritdoc />
    public virtual string GenusName => "Chimarrogale";

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
