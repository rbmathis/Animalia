using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Crinia;

/// <summary>
/// Abstract class for Crinia (genus).
/// NCBI TaxId: 8373
/// </summary>
public abstract class Crinia : Myobatrachidae, ICrinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8373;

    /// <inheritdoc />
    public virtual string GenusName => "Crinia";

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
