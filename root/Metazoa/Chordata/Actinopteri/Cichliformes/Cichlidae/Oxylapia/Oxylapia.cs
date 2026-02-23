using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Oxylapia;

/// <summary>
/// Abstract class for Oxylapia (genus).
/// NCBI TaxId: 51794
/// </summary>
public abstract class Oxylapia : Cichlidae, IOxylapia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxylapia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 51794;

    /// <inheritdoc />
    public virtual string GenusName => "Oxylapia";

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
