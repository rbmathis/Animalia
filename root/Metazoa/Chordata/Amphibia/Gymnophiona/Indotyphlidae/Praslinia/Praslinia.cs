using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Indotyphlidae.Praslinia;

/// <summary>
/// Abstract class for Praslinia (genus).
/// NCBI TaxId: 264018
/// </summary>
public abstract class Praslinia : Indotyphlidae, IPraslinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Praslinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264018;

    /// <inheritdoc />
    public virtual string GenusName => "Praslinia";

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
