using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Lithognathus;

/// <summary>
/// Abstract class for Lithognathus (genus).
/// NCBI TaxId: 50590
/// </summary>
public abstract class Lithognathus : Sparidae, ILithognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lithognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 50590;

    /// <inheritdoc />
    public virtual string GenusName => "Lithognathus";

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
