using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Melanochlora;

/// <summary>
/// Abstract class for Melanochlora (genus).
/// NCBI TaxId: 237429
/// </summary>
public abstract class Melanochlora : Paridae, IMelanochlora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanochlora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237429;

    /// <inheritdoc />
    public virtual string GenusName => "Melanochlora";

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
