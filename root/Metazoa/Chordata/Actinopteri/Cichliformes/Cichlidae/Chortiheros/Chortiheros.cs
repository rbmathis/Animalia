using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chortiheros;

/// <summary>
/// Abstract class for Chortiheros (genus).
/// NCBI TaxId: 2021275
/// </summary>
public abstract class Chortiheros : Cichlidae, IChortiheros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chortiheros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2021275;

    /// <inheritdoc />
    public virtual string GenusName => "Chortiheros";

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
