using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Locustellidae.Malia;

/// <summary>
/// Abstract class for Malia (genus).
/// NCBI TaxId: 1149645
/// </summary>
public abstract class Malia : Locustellidae, IMalia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Malia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1149645;

    /// <inheritdoc />
    public virtual string GenusName => "Malia";

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
