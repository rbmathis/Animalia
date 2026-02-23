using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Lophiidae.Sladenia;

/// <summary>
/// Abstract class for Sladenia (genus).
/// NCBI TaxId: 210607
/// </summary>
public abstract class Sladenia : Lophiidae, ISladenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sladenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210607;

    /// <inheritdoc />
    public virtual string GenusName => "Sladenia";

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
