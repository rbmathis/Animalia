using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Rhamphochromis;

/// <summary>
/// Abstract class for Rhamphochromis (genus).
/// NCBI TaxId: 28824
/// </summary>
public abstract class Rhamphochromis : Cichlidae, IRhamphochromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhamphochromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28824;

    /// <inheritdoc />
    public virtual string GenusName => "Rhamphochromis";

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
