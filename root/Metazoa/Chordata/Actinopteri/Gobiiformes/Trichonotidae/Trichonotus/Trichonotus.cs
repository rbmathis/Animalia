using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Trichonotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Trichonotidae.Trichonotus;

/// <summary>
/// Abstract class for Trichonotus (genus).
/// NCBI TaxId: 270660
/// </summary>
public abstract class Trichonotus : Trichonotidae, ITrichonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270660;

    /// <inheritdoc />
    public virtual string GenusName => "Trichonotus";

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
