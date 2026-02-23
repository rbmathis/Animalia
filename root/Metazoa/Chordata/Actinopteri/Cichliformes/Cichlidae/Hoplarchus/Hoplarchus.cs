using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Hoplarchus;

/// <summary>
/// Abstract class for Hoplarchus (genus).
/// NCBI TaxId: 74120
/// </summary>
public abstract class Hoplarchus : Cichlidae, IHoplarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hoplarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74120;

    /// <inheritdoc />
    public virtual string GenusName => "Hoplarchus";

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
