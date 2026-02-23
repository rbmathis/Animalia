using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Coilia;

/// <summary>
/// Abstract class for Coilia (genus).
/// NCBI TaxId: 286536
/// </summary>
public abstract class Coilia : Engraulidae, ICoilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286536;

    /// <inheritdoc />
    public virtual string GenusName => "Coilia";

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
