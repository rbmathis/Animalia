using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Metacrinia;

/// <summary>
/// Abstract class for Metacrinia (genus).
/// NCBI TaxId: 356306
/// </summary>
public abstract class Metacrinia : Myobatrachidae, IMetacrinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Metacrinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356306;

    /// <inheritdoc />
    public virtual string GenusName => "Metacrinia";

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
