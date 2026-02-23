using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Paracrinia;

/// <summary>
/// Abstract class for Paracrinia (genus).
/// NCBI TaxId: 356315
/// </summary>
public abstract class Paracrinia : Myobatrachidae, IParacrinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracrinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 356315;

    /// <inheritdoc />
    public virtual string GenusName => "Paracrinia";

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
