using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pelasgus;

/// <summary>
/// Abstract class for Pelasgus (genus).
/// NCBI TaxId: 752552
/// </summary>
public abstract class Pelasgus : Leuciscidae, IPelasgus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelasgus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 752552;

    /// <inheritdoc />
    public virtual string GenusName => "Pelasgus";

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
