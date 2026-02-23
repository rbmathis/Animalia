using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Leptoglanis;

/// <summary>
/// Abstract class for Leptoglanis (genus).
/// NCBI TaxId: 1108841
/// </summary>
public abstract class Leptoglanis : Amphiliidae, ILeptoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1108841;

    /// <inheritdoc />
    public virtual string GenusName => "Leptoglanis";

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
