using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Geocrinia;

/// <summary>
/// Abstract class for Geocrinia (genus).
/// NCBI TaxId: 356298
/// </summary>
public abstract class Geocrinia : Myobatrachidae, IGeocrinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geocrinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356298;

    /// <inheritdoc />
    public virtual string GenusName => "Geocrinia";

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
