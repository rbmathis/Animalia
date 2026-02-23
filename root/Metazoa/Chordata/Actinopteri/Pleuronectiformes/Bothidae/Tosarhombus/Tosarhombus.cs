using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Tosarhombus;

/// <summary>
/// Abstract class for Tosarhombus (genus).
/// NCBI TaxId: 1609625
/// </summary>
public abstract class Tosarhombus : Bothidae, ITosarhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tosarhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1609625;

    /// <inheritdoc />
    public virtual string GenusName => "Tosarhombus";

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
