using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Neobola;

/// <summary>
/// Abstract class for Neobola (genus).
/// NCBI TaxId: 857699
/// </summary>
public abstract class Neobola : Danionidae, INeobola
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neobola";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 857699;

    /// <inheritdoc />
    public virtual string GenusName => "Neobola";

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
