using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Hypsolebias;

/// <summary>
/// Abstract class for Hypsolebias (genus).
/// NCBI TaxId: 941673
/// </summary>
public abstract class Hypsolebias : Rivulidae, IHypsolebias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypsolebias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 941673;

    /// <inheritdoc />
    public virtual string GenusName => "Hypsolebias";

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
