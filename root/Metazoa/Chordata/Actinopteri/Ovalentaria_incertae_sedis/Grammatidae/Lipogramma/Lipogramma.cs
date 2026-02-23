using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Grammatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Grammatidae.Lipogramma;

/// <summary>
/// Abstract class for Lipogramma (genus).
/// NCBI TaxId: 1182855
/// </summary>
public abstract class Lipogramma : Grammatidae, ILipogramma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lipogramma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182855;

    /// <inheritdoc />
    public virtual string GenusName => "Lipogramma";

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
