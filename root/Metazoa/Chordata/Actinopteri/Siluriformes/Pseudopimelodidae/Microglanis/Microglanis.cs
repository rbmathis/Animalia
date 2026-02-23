using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Microglanis;

/// <summary>
/// Abstract class for Microglanis (genus).
/// NCBI TaxId: 337755
/// </summary>
public abstract class Microglanis : Pseudopimelodidae, IMicroglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337755;

    /// <inheritdoc />
    public virtual string GenusName => "Microglanis";

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
