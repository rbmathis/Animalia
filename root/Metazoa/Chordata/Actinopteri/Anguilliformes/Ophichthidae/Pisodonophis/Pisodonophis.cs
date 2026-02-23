using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Pisodonophis;

/// <summary>
/// Abstract class for Pisodonophis (genus).
/// NCBI TaxId: 189509
/// </summary>
public abstract class Pisodonophis : Ophichthidae, IPisodonophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pisodonophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189509;

    /// <inheritdoc />
    public virtual string GenusName => "Pisodonophis";

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
