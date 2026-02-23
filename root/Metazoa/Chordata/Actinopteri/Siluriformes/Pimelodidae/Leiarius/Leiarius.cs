using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Pimelodidae.Leiarius;

/// <summary>
/// Abstract class for Leiarius (genus).
/// NCBI TaxId: 380995
/// </summary>
public abstract class Leiarius : Pimelodidae, ILeiarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leiarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 380995;

    /// <inheritdoc />
    public virtual string GenusName => "Leiarius";

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
