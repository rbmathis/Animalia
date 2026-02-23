using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Argopleura;

/// <summary>
/// Abstract class for Argopleura (genus).
/// NCBI TaxId: 1463112
/// </summary>
public abstract class Argopleura : Stevardiidae, IArgopleura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Argopleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463112;

    /// <inheritdoc />
    public virtual string GenusName => "Argopleura";

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
