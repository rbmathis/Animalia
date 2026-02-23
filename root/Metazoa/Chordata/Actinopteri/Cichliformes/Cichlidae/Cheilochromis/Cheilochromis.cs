using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Cheilochromis;

/// <summary>
/// Abstract class for Cheilochromis (genus).
/// NCBI TaxId: 316405
/// </summary>
public abstract class Cheilochromis : Cichlidae, ICheilochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cheilochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 316405;

    /// <inheritdoc />
    public virtual string GenusName => "Cheilochromis";

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
