using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Cyanogaster;

/// <summary>
/// Abstract class for Cyanogaster (genus).
/// NCBI TaxId: 2608211
/// </summary>
public abstract class Cyanogaster : Characidae, ICyanogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608211;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanogaster";

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
