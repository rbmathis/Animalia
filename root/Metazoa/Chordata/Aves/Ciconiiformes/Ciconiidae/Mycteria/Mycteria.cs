using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Ciconiidae.Mycteria;

/// <summary>
/// Abstract class for Mycteria (genus).
/// NCBI TaxId: 33585
/// </summary>
public abstract class Mycteria : Ciconiidae, IMycteria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mycteria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33585;

    /// <inheritdoc />
    public virtual string GenusName => "Mycteria";

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
