using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Pinirampus;

/// <summary>
/// Abstract class for Pinirampus (genus).
/// NCBI TaxId: 337628
/// </summary>
public abstract class Pinirampus : Pimelodidae, IPinirampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pinirampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337628;

    /// <inheritdoc />
    public virtual string GenusName => "Pinirampus";

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
