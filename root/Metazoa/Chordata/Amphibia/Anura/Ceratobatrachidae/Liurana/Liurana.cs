using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratobatrachidae.Liurana;

/// <summary>
/// Abstract class for Liurana (genus).
/// NCBI TaxId: 1795274
/// </summary>
public abstract class Liurana : Ceratobatrachidae, ILiurana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Liurana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1795274;

    /// <inheritdoc />
    public virtual string GenusName => "Liurana";

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
