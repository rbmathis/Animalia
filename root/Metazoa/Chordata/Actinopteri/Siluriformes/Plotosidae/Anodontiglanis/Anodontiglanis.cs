using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Anodontiglanis;

/// <summary>
/// Abstract class for Anodontiglanis (genus).
/// NCBI TaxId: 2850007
/// </summary>
public abstract class Anodontiglanis : Plotosidae, IAnodontiglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anodontiglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2850007;

    /// <inheritdoc />
    public virtual string GenusName => "Anodontiglanis";

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
