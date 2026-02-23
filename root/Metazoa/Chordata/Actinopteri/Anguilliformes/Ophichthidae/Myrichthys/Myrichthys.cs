using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Myrichthys;

/// <summary>
/// Abstract class for Myrichthys (genus).
/// NCBI TaxId: 182434
/// </summary>
public abstract class Myrichthys : Ophichthidae, IMyrichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myrichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182434;

    /// <inheritdoc />
    public virtual string GenusName => "Myrichthys";

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
