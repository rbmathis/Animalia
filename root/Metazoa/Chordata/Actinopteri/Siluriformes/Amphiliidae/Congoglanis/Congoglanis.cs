using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Amphiliidae.Congoglanis;

/// <summary>
/// Abstract class for Congoglanis (genus).
/// NCBI TaxId: 1233687
/// </summary>
public abstract class Congoglanis : Amphiliidae, ICongoglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Congoglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1233687;

    /// <inheritdoc />
    public virtual string GenusName => "Congoglanis";

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
