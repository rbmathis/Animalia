using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Paratilapia;

/// <summary>
/// Abstract class for Paratilapia (genus).
/// NCBI TaxId: 80771
/// </summary>
public abstract class Paratilapia : Cichlidae, IParatilapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paratilapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80771;

    /// <inheritdoc />
    public virtual string GenusName => "Paratilapia";

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
