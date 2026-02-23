using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Meristogenys;

/// <summary>
/// Abstract class for Meristogenys (genus).
/// NCBI TaxId: 240396
/// </summary>
public abstract class Meristogenys : Ranidae, IMeristogenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meristogenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 240396;

    /// <inheritdoc />
    public virtual string GenusName => "Meristogenys";

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
