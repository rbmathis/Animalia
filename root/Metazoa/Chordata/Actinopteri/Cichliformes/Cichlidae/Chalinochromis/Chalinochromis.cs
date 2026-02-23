using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Chalinochromis;

/// <summary>
/// Abstract class for Chalinochromis (genus).
/// NCBI TaxId: 32493
/// </summary>
public abstract class Chalinochromis : Cichlidae, IChalinochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalinochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32493;

    /// <inheritdoc />
    public virtual string GenusName => "Chalinochromis";

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
