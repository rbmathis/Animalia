using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Myoxocephalus;

/// <summary>
/// Abstract class for Myoxocephalus (genus).
/// NCBI TaxId: 8095
/// </summary>
public abstract class Myoxocephalus : Cottidae, IMyoxocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myoxocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8095;

    /// <inheritdoc />
    public virtual string GenusName => "Myoxocephalus";

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
