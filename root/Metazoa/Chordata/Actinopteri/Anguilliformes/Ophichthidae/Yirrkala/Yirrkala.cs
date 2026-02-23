using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Yirrkala;

/// <summary>
/// Abstract class for Yirrkala (genus).
/// NCBI TaxId: 1459855
/// </summary>
public abstract class Yirrkala : Ophichthidae, IYirrkala
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yirrkala";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1459855;

    /// <inheritdoc />
    public virtual string GenusName => "Yirrkala";

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
