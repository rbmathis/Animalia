using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Pellonula;

/// <summary>
/// Abstract class for Pellonula (genus).
/// NCBI TaxId: 402405
/// </summary>
public abstract class Pellonula : Clupeidae, IPellonula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pellonula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 402405;

    /// <inheritdoc />
    public virtual string GenusName => "Pellonula";

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
