using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Chaudhuriidae.Chaudhuria;

/// <summary>
/// Abstract class for Chaudhuria (genus).
/// NCBI TaxId: 1778385
/// </summary>
public abstract class Chaudhuria : Chaudhuriidae, IChaudhuria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaudhuria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1778385;

    /// <inheritdoc />
    public virtual string GenusName => "Chaudhuria";

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
