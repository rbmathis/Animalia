using AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Strigiformes.Strigidae.Surnia;

/// <summary>
/// Abstract class for Surnia (genus).
/// NCBI TaxId: 69939
/// </summary>
public abstract class Surnia : Strigidae, ISurnia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Surnia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69939;

    /// <inheritdoc />
    public virtual string GenusName => "Surnia";

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
