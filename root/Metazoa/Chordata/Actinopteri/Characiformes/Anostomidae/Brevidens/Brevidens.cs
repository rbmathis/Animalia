using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Brevidens;

/// <summary>
/// Abstract class for Brevidens (genus).
/// NCBI TaxId: 3411575
/// </summary>
public abstract class Brevidens : Anostomidae, IBrevidens
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brevidens";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3411575;

    /// <inheritdoc />
    public virtual string GenusName => "Brevidens";

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
