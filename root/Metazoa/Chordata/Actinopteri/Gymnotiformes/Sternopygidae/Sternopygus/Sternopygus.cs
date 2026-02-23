using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gymnotiformes.Sternopygidae.Sternopygus;

/// <summary>
/// Abstract class for Sternopygus (genus).
/// NCBI TaxId: 36697
/// </summary>
public abstract class Sternopygus : Sternopygidae, ISternopygus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternopygus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36697;

    /// <inheritdoc />
    public virtual string GenusName => "Sternopygus";

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
