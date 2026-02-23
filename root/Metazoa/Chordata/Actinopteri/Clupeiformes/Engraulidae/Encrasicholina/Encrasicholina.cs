using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Encrasicholina;

/// <summary>
/// Abstract class for Encrasicholina (genus).
/// NCBI TaxId: 495044
/// </summary>
public abstract class Encrasicholina : Engraulidae, IEncrasicholina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Encrasicholina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495044;

    /// <inheritdoc />
    public virtual string GenusName => "Encrasicholina";

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
