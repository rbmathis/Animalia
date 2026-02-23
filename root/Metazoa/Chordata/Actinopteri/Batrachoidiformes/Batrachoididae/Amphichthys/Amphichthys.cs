using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Batrachoidiformes.Batrachoididae.Amphichthys;

/// <summary>
/// Abstract class for Amphichthys (genus).
/// NCBI TaxId: 747526
/// </summary>
public abstract class Amphichthys : Batrachoididae, IAmphichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amphichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 747526;

    /// <inheritdoc />
    public virtual string GenusName => "Amphichthys";

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
