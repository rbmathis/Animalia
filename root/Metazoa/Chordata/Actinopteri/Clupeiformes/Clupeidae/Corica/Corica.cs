using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Corica;

/// <summary>
/// Abstract class for Corica (genus).
/// NCBI TaxId: 689650
/// </summary>
public abstract class Corica : Clupeidae, ICorica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 689650;

    /// <inheritdoc />
    public virtual string GenusName => "Corica";

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
