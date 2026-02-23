using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lestradea;

/// <summary>
/// Abstract class for Lestradea (genus).
/// NCBI TaxId: 27746
/// </summary>
public abstract class Lestradea : Cichlidae, ILestradea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lestradea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27746;

    /// <inheritdoc />
    public virtual string GenusName => "Lestradea";

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
