using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Theraps;

/// <summary>
/// Abstract class for Theraps (genus).
/// NCBI TaxId: 64094
/// </summary>
public abstract class Theraps : Cichlidae, ITheraps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Theraps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 64094;

    /// <inheritdoc />
    public virtual string GenusName => "Theraps";

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
