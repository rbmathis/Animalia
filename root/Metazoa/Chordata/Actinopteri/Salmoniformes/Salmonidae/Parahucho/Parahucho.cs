using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Salmoniformes.Salmonidae.Parahucho;

/// <summary>
/// Abstract class for Parahucho (genus).
/// NCBI TaxId: 504709
/// </summary>
public abstract class Parahucho : Salmonidae, IParahucho
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parahucho";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 504709;

    /// <inheritdoc />
    public virtual string GenusName => "Parahucho";

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
