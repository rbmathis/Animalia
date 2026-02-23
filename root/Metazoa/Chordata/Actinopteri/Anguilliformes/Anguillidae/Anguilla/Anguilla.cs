using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Anguillidae.Anguilla;

/// <summary>
/// Abstract class for Anguilla (genus).
/// NCBI TaxId: 7935
/// </summary>
public abstract class Anguilla : Anguillidae, IAnguilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anguilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7935;

    /// <inheritdoc />
    public virtual string GenusName => "Anguilla";

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
