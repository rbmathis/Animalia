using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Condylura;

/// <summary>
/// Abstract class for Condylura (genus).
/// NCBI TaxId: 143301
/// </summary>
public abstract class Condylura : Talpidae, ICondylura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Condylura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143301;

    /// <inheritdoc />
    public virtual string GenusName => "Condylura";

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
