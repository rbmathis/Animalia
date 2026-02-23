using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Batrochoglanis;

/// <summary>
/// Abstract class for Batrochoglanis (genus).
/// NCBI TaxId: 390399
/// </summary>
public abstract class Batrochoglanis : Pseudopimelodidae, IBatrochoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrochoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390399;

    /// <inheritdoc />
    public virtual string GenusName => "Batrochoglanis";

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
