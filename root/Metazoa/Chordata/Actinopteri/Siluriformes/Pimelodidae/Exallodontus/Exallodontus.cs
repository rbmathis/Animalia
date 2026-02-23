using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Exallodontus;

/// <summary>
/// Abstract class for Exallodontus (genus).
/// NCBI TaxId: 1150226
/// </summary>
public abstract class Exallodontus : Pimelodidae, IExallodontus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exallodontus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1150226;

    /// <inheritdoc />
    public virtual string GenusName => "Exallodontus";

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
