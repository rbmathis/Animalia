using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Hemigrammocharax;

/// <summary>
/// Abstract class for Hemigrammocharax (genus).
/// NCBI TaxId: 304024
/// </summary>
public abstract class Hemigrammocharax : Distichodontidae, IHemigrammocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemigrammocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304024;

    /// <inheritdoc />
    public virtual string GenusName => "Hemigrammocharax";

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
