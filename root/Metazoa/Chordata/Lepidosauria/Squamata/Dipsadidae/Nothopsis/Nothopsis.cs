using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Nothopsis;

/// <summary>
/// Abstract class for Nothopsis (genus).
/// NCBI TaxId: 758880
/// </summary>
public abstract class Nothopsis : Dipsadidae, INothopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nothopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 758880;

    /// <inheritdoc />
    public virtual string GenusName => "Nothopsis";

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
