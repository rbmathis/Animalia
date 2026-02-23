using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Leiuranus;

/// <summary>
/// Abstract class for Leiuranus (genus).
/// NCBI TaxId: 1156472
/// </summary>
public abstract class Leiuranus : Ophichthidae, ILeiuranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiuranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156472;

    /// <inheritdoc />
    public virtual string GenusName => "Leiuranus";

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
