using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Bothidae.Crossorhombus;

/// <summary>
/// Abstract class for Crossorhombus (genus).
/// NCBI TaxId: 195603
/// </summary>
public abstract class Crossorhombus : Bothidae, ICrossorhombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Crossorhombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 195603;

    /// <inheritdoc />
    public virtual string GenusName => "Crossorhombus";

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
