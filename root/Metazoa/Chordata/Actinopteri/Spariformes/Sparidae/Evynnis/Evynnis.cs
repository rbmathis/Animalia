using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Evynnis;

/// <summary>
/// Abstract class for Evynnis (genus).
/// NCBI TaxId: 119714
/// </summary>
public abstract class Evynnis : Sparidae, IEvynnis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Evynnis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119714;

    /// <inheritdoc />
    public virtual string GenusName => "Evynnis";

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
