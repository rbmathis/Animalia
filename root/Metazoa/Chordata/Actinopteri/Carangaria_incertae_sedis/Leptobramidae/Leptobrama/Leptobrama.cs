using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Leptobramidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Leptobramidae.Leptobrama;

/// <summary>
/// Abstract class for Leptobrama (genus).
/// NCBI TaxId: 334897
/// </summary>
public abstract class Leptobrama : Leptobramidae, ILeptobrama
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptobrama";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334897;

    /// <inheritdoc />
    public virtual string GenusName => "Leptobrama";

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
