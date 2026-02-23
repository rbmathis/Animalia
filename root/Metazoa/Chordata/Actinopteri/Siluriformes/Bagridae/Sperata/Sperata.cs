using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Bagridae.Sperata;

/// <summary>
/// Abstract class for Sperata (genus).
/// NCBI TaxId: 402708
/// </summary>
public abstract class Sperata : Bagridae, ISperata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sperata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 402708;

    /// <inheritdoc />
    public virtual string GenusName => "Sperata";

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
