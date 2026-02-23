using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Chiloglanis;

/// <summary>
/// Abstract class for Chiloglanis (genus).
/// NCBI TaxId: 392958
/// </summary>
public abstract class Chiloglanis : Mochokidae, IChiloglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiloglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392958;

    /// <inheritdoc />
    public virtual string GenusName => "Chiloglanis";

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
