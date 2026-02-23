using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Machlolophus;

/// <summary>
/// Abstract class for Machlolophus (genus).
/// NCBI TaxId: 1356379
/// </summary>
public abstract class Machlolophus : Paridae, IMachlolophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Machlolophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1356379;

    /// <inheritdoc />
    public virtual string GenusName => "Machlolophus";

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
