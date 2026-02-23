using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Aegypius;

/// <summary>
/// Abstract class for Aegypius (genus).
/// NCBI TaxId: 8958
/// </summary>
public abstract class Aegypius : Accipitridae, IAegypius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aegypius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8958;

    /// <inheritdoc />
    public virtual string GenusName => "Aegypius";

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
