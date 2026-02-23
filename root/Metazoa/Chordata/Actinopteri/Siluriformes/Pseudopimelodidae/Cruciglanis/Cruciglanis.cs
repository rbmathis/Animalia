using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pseudopimelodidae.Cruciglanis;

/// <summary>
/// Abstract class for Cruciglanis (genus).
/// NCBI TaxId: 2588699
/// </summary>
public abstract class Cruciglanis : Pseudopimelodidae, ICruciglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cruciglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2588699;

    /// <inheritdoc />
    public virtual string GenusName => "Cruciglanis";

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
