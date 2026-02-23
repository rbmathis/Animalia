using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Procatopodidae.Lacustricola;

/// <summary>
/// Abstract class for Lacustricola (genus).
/// NCBI TaxId: 2546135
/// </summary>
public abstract class Lacustricola : Procatopodidae, ILacustricola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lacustricola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2546135;

    /// <inheritdoc />
    public virtual string GenusName => "Lacustricola";

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
